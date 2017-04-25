using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;
using Dapper;
using System.Linq;

namespace MSF.LogisticsPlatform.Domain.Database
{
    /*
     * This class is responsible for getting all products, product by id and filters 
     * by using stored procedures.
     */
    public class ProductProcedures : IProductProcedures
    {
        private readonly IDbConnection _dbConnection;

        public ProductProcedures(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Getting all the products as IEnumerable(read only) from DB by using stored Procedure
        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, "dbo.GetFilteredProductList", commandType: CommandType.StoredProcedure);
            return productList;
        }
        //Getting a single product by id using Dapper.
        public Product GetById(int id)
        {
            //Retrieving certain coloumns from vProductData and ProductFile tables.
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

        /*
         * Getting filtered products
         * para@ string:stored procedure parameters
         * ret@ IEnumerable<Product>:read only productList
         */
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
