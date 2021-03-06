﻿using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        void Add(Product prod);
        //MemoryStream GetProductThumbnail(int productPhotoID);
        //MemoryStream GetProductPhoto(int productPhotoID);
        
    }
}
