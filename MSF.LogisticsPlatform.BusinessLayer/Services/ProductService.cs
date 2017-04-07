using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Repositories;
using System.IO;
using MSF.LogisticsPlatform.BusinessLayer.UnitOfWorks;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<Product> GetAll()
        {
            return _unitOfWork.ProductRepository.GetAll();
        }

        public Product Get(int id)
        {
            return _unitOfWork.ProductRepository.Get(id);
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
        public void Add(Product prod)
        {
            _unitOfWork.ProductRepository.Add(prod);
        }
    }
}
