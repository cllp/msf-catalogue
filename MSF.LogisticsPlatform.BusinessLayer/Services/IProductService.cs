using MSF.LogisticsPlatform.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetProductsByFilter(Filter filter);
        Product Get(int id);
        void Add(Product prod);
        

    }
}