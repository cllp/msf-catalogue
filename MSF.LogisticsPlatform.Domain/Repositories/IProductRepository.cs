using MSF.LogisticsPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductDetail> GetAll(int id);
    }
}
