using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer
{
    public interface IServiceFactory
    {
        Services.IProductService GetProductService();
        Services.IFilterService GetFilterService();
    }
}
