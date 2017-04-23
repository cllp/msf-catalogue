using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;
using Dapper;
using System.Linq;

namespace MSF.LogisticsPlatform.Domain.Database
{
    public class ProductProcedures : IProductProcedures
    {
        private readonly IDbConnection _dbConnection;

        public ProductProcedures(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, "dbo.GetFilteredProductList", commandType: CommandType.StoredProcedure);
            return productList;
        }

        public Product GetById(int id)
        {


            var sqlQuery = @" 
                select  * FROM dbo.vProductData Where vProductData.ProductID =@id

                select  ProductID, ProductFileName, FDescription from ProductFile where ProductID =@id ";

           using (var multi = _dbConnection.QueryMultiple(sqlQuery, new { id = id }))
            {

                var products = multi.Read<Product>().SingleOrDefault();
                var imageFile = multi.Read<ProductFile>().ToList();

                if (products != null && imageFile != null)
                {
                    
                    products.imageFile.AddRange(imageFile);

                }
                return products;
            }


        }

        public IEnumerable<Product> GetFilteredProducts(string parameterAsArray)
        {
            StringBuilder query = new StringBuilder();
            query.Append("Exec dbo.GetFilteredProductList ");
            query.Append(parameterAsArray);

            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, query.ToString());
            return productList;
        }
    }

}
