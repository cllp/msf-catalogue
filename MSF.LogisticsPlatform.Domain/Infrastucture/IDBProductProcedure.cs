using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Infrastucture.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Infrastucture
{
    public interface IDBProductProcedure
    {
        IEnumerable<Product> GetFilteredProducts(ProductFilter productFilter);
    }
}
