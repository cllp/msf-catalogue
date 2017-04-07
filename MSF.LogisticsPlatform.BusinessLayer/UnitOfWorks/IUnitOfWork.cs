using MSF.LogisticsPlatform.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MSF.LogisticsPlatform.BusinessLayer.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        void Complete();
    }
}
