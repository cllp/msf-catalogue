using MSF.LogisticsPlatform.Domain.Database.Data;
using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Database
{
    public interface IProductProcedures
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetFilteredProducts(ShelterFilter productFilter);
    }
}
