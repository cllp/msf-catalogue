using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.BusinessLayer.Services;
using MSF.LogisticsPlatform.BusinessLayer.UnitOfWorks;

namespace MSF.LogisticsPlatform.BusinessLayer
{
    public class ServiceFactory : IServiceFactory
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceFactory(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IProductService GetProductService()
        {
            return new Services.ProductService(_unitOfWork);
        }
    }
}
