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

        /*
         * Getting one specific product by {id}
         * para@ int:product id
         * ret@ IEnumerable<Product>:read only product as IEnumerable
         */
        public IEnumerable<ProductDetail> GetById(int id)
        {
            //Retrieve the data of the product
            IEnumerable<ProductDetail> productDetail = SqlMapper.Query<ProductDetail>(_dbConnection, "SELECT * FROM dbo.vProductData Where ProductID =" + id);
            //Retrieve the image of the product using stored procedure
            IEnumerable<ProductFile> productFileList = SqlMapper.Query<ProductFile>(_dbConnection, "Exec dbo.GetProductPictureList " + id, commandType: CommandType.Text);
            //
            IEnumerable<Entities.Attribute> productComments = SqlMapper.Query<Entities.Attribute>(_dbConnection, "Exec dbo.GetFeedBackComment " + id, commandType: CommandType.Text);
            
            //Get the image of the product from vProductData table and attach it to the product
            foreach (var productFile in productFileList)
            {
                productDetail.ElementAt(0).imageFile.Add(productFile);               
            }
            foreach (var productComment in productComments)
            {
                productDetail.ElementAt(0).comments.Add(productComment);
            }
            return productDetail;
        }

        /*
         * Getting filtered products
         * para@ string:stored procedure parameters
         * ret@ IEnumerable<Product>:read only productList
         */
        public IEnumerable<Product> GetFilteredProducts(string parameterAsArray)
        {
            StringBuilder query = new StringBuilder();
            query.Append("Exec dbo.GetFilteredProductList ");//append the stored procedure for filtered products
            query.Append(parameterAsArray);

            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, query.ToString());
            return productList;
        }
    }

}
