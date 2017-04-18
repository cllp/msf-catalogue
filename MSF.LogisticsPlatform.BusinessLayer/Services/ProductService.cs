using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using AutoMapper;
using Dapper;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Database;
using MSF.LogisticsPlatform.Domain.Repositories;

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

                var productRepository = new ProductRepository(dbConnection);

                var productDetailEntity = productRepository.GetAll(id);

                Mapper.Initialize(cfg => cfg.CreateMap<ProductDetail, Domain.Entities.ProductDetail>().ReverseMap());


                //// Define the default mapping, 
                //// custom configuration can be also defined and will be merged with this one

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

                // Define the default mapping, 
                // custom configuration can be also defined and will be merged with this one
                Mapper.Initialize(cfg => cfg.CreateMap<Product, Domain.Entities.Product>());
                Mapper.Initialize(cfg => cfg.CreateMap<Domain.Entities.Product, Product>());

                // map entities to models
                var productModel = Mapper.Map<List<Product>>(entities);
                return productModel;
            }
        }

        public IEnumerable<Product> GetProductsByFilter(string category, IEnumerable<FilterGroup> filterGroup)
        {
            if (category == "Shelter")
            {
                using (var dbConnection = _dbConnectionFactory.Connection)
                {
                    if (dbConnection.State == System.Data.ConnectionState.Open) dbConnection.Close(); dbConnection.Open(); var productProcedures = new ProductProcedures(dbConnection);
                    var entities = productProcedures.GetFilteredProducts(filterGroup.Translate());
                }
            }
            throw new NotImplementedException();
        }
    }
}
