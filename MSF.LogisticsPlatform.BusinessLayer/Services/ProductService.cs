using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using MSF.LogisticsPlatform.Domain.Infrastucture;
using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Infrastucture.Data;

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
                var unitOfWorkProduct = new UnitOfWorkProduct(dbConnection);
                var productCollection = new List<Product>();
                var productEntities = unitOfWorkProduct.GetProductProcedures().GetFilteredProducts(new ProductFilter());

                // Use automapper to map entity to model

                return unitOfWorkProduct.GetProductRepository.GetAll();
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
