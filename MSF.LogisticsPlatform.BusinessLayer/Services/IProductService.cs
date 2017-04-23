using MSF.LogisticsPlatform.BusinessLayer.Models;
using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetProductsByFilter(string category, IEnumerable<FilterGroup> filterGroup);
        Product Get(int id);
        //void Add(Product prod);
        

    }
}