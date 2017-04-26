﻿using System;
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


        public IEnumerable<ProductDetail> GetById(int id)
        {


            /*var sqlQuery = @" 
                select  * FROM dbo.vProductData Where vProductData.ProductID =@id

                select  ProductID, ProductFileName, FDescription from ProductFile where ProductID =@id ";*/

            IEnumerable<ProductDetail> productDetailList = SqlMapper.Query<ProductDetail>(_dbConnection, "SELECT * FROM dbo.vProductData Where ProductID =" + id);
            IEnumerable<ProductFile> productFileList = SqlMapper.Query<ProductFile>(_dbConnection, "Exec dbo.GetProductPictureList " + id, commandType: CommandType.Text);

            IEnumerable<ProductDetail> productDetail = new List<ProductDetail>();
            productDetail = productDetailList;

            foreach (var productFile in productFileList)
            {
                productDetail.ElementAt(0).imageFile.Add(productFile);
            }

            /*using (var multi = _dbConnection.QueryMultiple(sqlQuery, new { id = id }))
            {
                var products = multi.Read<Product>().SingleOrDefault();
                var imageFile = multi.Read<ProductFile>().ToList();



                if (productDetails != null && imageFile != null)
                {

                    productDetails.imageFile.AddRange(imageFile);

                }
                return productDetails;
            }*/
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
            query.Append("Exec dbo.GetFilteredProductList ");
            query.Append(parameterAsArray);

            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, query.ToString());
            return productList;
        }
    }

}
