using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Database
{
    public interface IProductProcedures
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetFilteredProducts(string parameterAsArray);
        IEnumerable<ProductDetail> GetById(int id);
    }
}
