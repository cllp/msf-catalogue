using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Database;
using MSF.LogisticsPlatform.Domain.Database.Data;

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
                dbConnection.Open();
                var productProcedures = new ProductProcedures(dbConnection);
                var productCollection = new List<Product>();
                var productEntities = productProcedures.GetFilteredProducts(new ShelterFilter());

                // Use automapper to map entity to model

                //
                //return unitOfWorkProduct.GetProductRepository.GetAll();
                throw new NotImplementedException();

            }

        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        /*public MemoryStream GetProductPhoto(int productPhotoID)
        {
            return _unitOfWork.ProductRepository.GetProductPhoto(productPhotoID);
        }
         public MemoryStream GetProductThumbNail(int productPhotoID)
         {
             return _unitOfWork.ProductRepository.GetProductThumbnail(productPhotoID);
         }

         /*public Product GetProductInformation()
         {
             return _unitOfWork.ProductRepository.GetProductInformation();
         }*/


        IEnumerable<Product> IProductService.GetAll()
        {
            using (var dbConnection = _dbConnectionFactory.Connection)
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                    dbConnection.Close();

                dbConnection.Open();

                var productProcedures = new ProductProcedures(dbConnection);
                var entities = productProcedures.GetAllProducts();
                var models = new List<Models.Product>();

                // map entities to models

                return models;
            }
        }

        IEnumerable<Product> IProductService.GetProductsByFilter(Filter filter)
        {
            throw new NotImplementedException();
        }

        Product IProductService.Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
