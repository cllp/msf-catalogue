using System;
using System.Collections.Generic;
using System.Text;
using MSF.LogisticsPlatform.Domain.Infrastucture.Data;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;

namespace MSF.LogisticsPlatform.Domain.Infrastucture
{
    public class DBProductProcedure : IDBProductProcedure
    {
        private readonly IDbConnection _dbConnection;

        public DBProductProcedure(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public IEnumerable<Product> GetFilteredProducts(ProductFilter productFilter)
        {

            if (productFilter.FetchAll)
            {

            }
            // Use dapper to map
            throw new NotImplementedException();
        }


    }
}
