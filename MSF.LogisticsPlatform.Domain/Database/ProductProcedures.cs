using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Database.Data;
using Dapper;
using System.Linq;

namespace MSF.LogisticsPlatform.Domain.Database
{
    public class ProductProcedures : IProductProcedures
    {
        private readonly IDbConnection _dbConnection;

        public ProductProcedures(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> productList = SqlMapper.Query<Product>(_dbConnection, "dbo.GetFilteredProductList", commandType: CommandType.StoredProcedure);
            return productList;
        }

        public IEnumerable<Product> GetFilteredProducts(ShelterFilter shelterFilter)
        {
            throw new NotImplementedException();
        }
    }
}
