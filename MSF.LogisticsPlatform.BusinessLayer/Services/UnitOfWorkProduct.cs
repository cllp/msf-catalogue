using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Repositories;
using MSF.LogisticsPlatform.Domain.Infrastucture;

namespace MSF.LogisticsPlatform.BusinessLayer.Services
{
    public class UnitOfWorkProduct : IUnitOfWorkProduct
    {
        private readonly IProductRepository _productRepository;
        private readonly IDBProductProcedure _dbProductProcedure;
        public UnitOfWorkProduct(IDbConnection dbConnection)
        {
            _productRepository = new ProductRepository(dbConnection);
            _dbProductProcedure = new DBProductProcedure(dbConnection);
        }

        public IProductRepository GetProductRepository()
        {
            return _productRepository;
        }

        public IDBProductProcedure GetProductProcedures()
        {
            return _dbProductProcedure;
        }
    }
}
