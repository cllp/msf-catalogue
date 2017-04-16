using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Database;
using AutoMapper;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;
        public ProductService(IDBConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

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
            //using (var dbConnection = _dbConnectionFactory.Connection)
            //{
            //    dbConnection.Open();
            //    var productProcedures = new ProductProcedures(dbConnection);
            //    var productCollection = new List<Product>();
            //    var productEntities = productProcedures.GetFilteredProducts(new ShelterFilter());

            //    // Use automapper to map entity to model

            //    //
            //    //return unitOfWorkProduct.GetProductRepository.GetAll();
            //    throw new NotImplementedException();

            //}

        }

        public IEnumerable<Product> GetProductsByFilter(Filter filter)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }        
        
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
