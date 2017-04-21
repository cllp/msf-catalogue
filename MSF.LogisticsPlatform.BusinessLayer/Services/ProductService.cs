using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AutoMapper;
using Dapper;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Database;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;

        public ProductService(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        public void Add(Product prod)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDetail> Get(int id)
        {
            // Get data to productDetails model
            using (var dbConnection = _dbConnectionFactory.Connection)
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }

                dbConnection.Open();

                var productRepository = new ProductProcedures(dbConnection);

                var productDetailEntity = productRepository.GetById(id);

                var productDetailModel = Mapper.Map<List<ProductDetail>>(productDetailEntity);
                return productDetailModel;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (var dbConnection = _dbConnectionFactory.Connection)
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                    dbConnection.Close();

                dbConnection.Open();

                var productProcedures = new ProductProcedures(dbConnection);
                var entities = productProcedures.GetAllProducts();

                var productModel = Mapper.Map<List<Product>>(entities);
                return productModel;
            }
        }

        public IEnumerable<Product> GetProductsByFilter(string category, IEnumerable<FilterGroup> filterGroup)
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
                    var productModel = Mapper.Map<List<Product>>(entities);
                    //IEnumerable<Product> filteredProducts = new IEnumerable<Product>(entities);
                    return productModel;
                }
            }
            throw new NotImplementedException();
        }
    }
}
