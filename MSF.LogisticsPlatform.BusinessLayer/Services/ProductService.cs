using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AutoMapper;
using Dapper;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Database;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    /*
     * This class will handle product services such as getting all products, one specific product or filtered products.
     * It uses stored procedures to fetch products from DB and return them as IEnumerable objects
     * 
     */
    public class ProductService : IProductService
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;

        public ProductService(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        //Retrieve one product by {id}
        public Product Get(int id)
        {
            using (var dbConnection = _dbConnectionFactory.Connection)
            {                
                dbConnection.Open();
                var productRepository = new ProductProcedures(dbConnection);
                // Initialize the mapper between Entities.Product and Model.ProductDetailModel models.
                Mapper.Initialize(cfg => cfg.CreateMap<Product, ProductDetailModel>());
                return AutoMapper.Mapper.Map<Product>(productRepository.GetById(id));
            }
        }

        //Retrieve all products
        public IEnumerable<ProductModel> GetAll()
        {
            using (var dbConnection = _dbConnectionFactory.Connection)
            {
                dbConnection.Open();
                var productProcedures = new ProductProcedures(dbConnection);              
                //
                var productModel = Mapper.Map<List<ProductModel>>(productProcedures.GetAllProducts());
                return productModel;
            }
        }
        /*
         * Get all filtered products from DB using stored procedures in ProductProcedures class
         * para@string: will be "shelter" always in this case
         * para@IEnumerable<FilterGroup>: filter group object (converted from json) that includes all checked and unchecked filters
         * ret@ IEnumerable<ProductModel>: all filtered products as list of IEnumerable objects
         */
        public IEnumerable<ProductModel> GetProductsByFilter(string category, IEnumerable<FilterGroup> filterGroup)
        {
            if (category == "shelter")
            {
                using (var dbConnection = _dbConnectionFactory.Connection)
                {
                    if (dbConnection.State == System.Data.ConnectionState.Open)
                        dbConnection.Close();
                    dbConnection.Open();
                    var productProcedures = new ProductProcedures(dbConnection);
                    var entities = productProcedures.GetFilteredProducts(filterGroup.GetAsParameterArray());
                    var productModel = Mapper.Map<List<ProductModel>>(entities);
                    return productModel;
                }
            }
            throw new NotImplementedException();
        }
    }
}
