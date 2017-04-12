using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.BusinessLayer.Services;
using System.Data;
using MSF.LogisticsPlatform.Domain.Infrastucture;

namespace MSF.LogisticsPlatform.BusinessLayer
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;
        public ServiceFactory()
        {
            _dbConnectionFactory = new DBConnectionFactory();
        }

        public IProductService GetProductService()
        {
            return new ProductService(_dbConnectionFactory);
        }

        public IFilterService GetFilterService()
        {
            return new FilterService(_dbConnectionFactory);
        }
    }
}
