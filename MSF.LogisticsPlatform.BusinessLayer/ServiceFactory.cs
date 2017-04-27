using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.BusinessLayer.Services;
using System.Data;
using MSF.LogisticsPlatform.Domain.Infrastructure;

namespace MSF.LogisticsPlatform.BusinessLayer
{
    /*
     * Service Factory to create services for the filter and for the product
     */
    public class ServiceFactory : IServiceFactory
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;
        public ServiceFactory()
        {
            _dbConnectionFactory = new DBConnectionFactory();
        }

        // Creating Product service
        public IProductService GetProductService()
        {
            return new ProductService(_dbConnectionFactory);
        }

        // Creating Filter service
        public IFilterService GetFilterService()
        {
            return new FilterService(_dbConnectionFactory);
        }
    }
}
