using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Infrastucture;

namespace MSF.LogisticsPlatform.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
         void Add(Product prod);
        //be implemented later
        //void Delete(int id);
        //new void Update(Product pro);
        //MemoryStream GetProductThumbnail(int productPhotoID);
       // MemoryStream GetProductPhoto(int productPhotoID);
    }

    
}
