using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Repositories;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public interface IUnitOfWorkProduct
    {
        IProductRepository GetProductRepository();
        // add other
    }
}
