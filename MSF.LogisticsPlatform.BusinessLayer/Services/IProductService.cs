using MSF.LogisticsPlatform.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetProductsByFilter(string category, IEnumerable<FilterGroup> filterGroup);
        IEnumerable<ProductDetailModel> Get(int id);
    }
}