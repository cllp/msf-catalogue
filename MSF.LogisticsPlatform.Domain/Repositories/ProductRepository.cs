using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Entities;
using System.Data;
using Dapper;

namespace MSF.LogisticsPlatform.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _dbConnection;

        public ProductRepository(IDbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }
        public IEnumerable<ProductDetail> GetAll(int id)
        {
            IEnumerable<ProductDetail> productDetailList;
            productDetailList = SqlMapper.Query<ProductDetail>(_dbConnection, "SELECT * FROM dbo.vProductData Where ProductID =" + id);
            return productDetailList;
        }
    }
}
