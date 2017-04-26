﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AutoMapper;
using Dapper;
using MSF.LogisticsPlatform.Domain.Infrastructure;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Database;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;

        public ProductService(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        public IEnumerable<ProductDetailModel> Get(int id)
        {
            // Get data to productDetails model
            using (var dbConnection = _dbConnectionFactory.Connection)
            {
                
                dbConnection.Open();

                var productProcedure = new ProductProcedures(dbConnection);

                var productModel = Mapper.Map<List<ProductDetailModel>>(productProcedure.GetById(id));

                return productModel;

            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            using (var dbConnection = _dbConnectionFactory.Connection)
            {

                dbConnection.Open();

                var productProcedures = new ProductProcedures(dbConnection);
                

                var productModel = Mapper.Map<List<ProductModel>>(productProcedures.GetAllProducts());
                return productModel;
            }
        }

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
                    //IEnumerable<Product> filteredProducts = new IEnumerable<Product>(entities);
                    return productModel;
                }
            }
            throw new NotImplementedException();
        }
    }
}
