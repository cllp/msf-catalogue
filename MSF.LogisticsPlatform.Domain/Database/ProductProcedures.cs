using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Database.Data;
using Dapper;

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
            //List<Product> productList = SqlMapper.Query<Product>(_dbConnection, "EXEC spFiltreratMeck()", CommandType.StoredProcedure).ToList();
            //return productList;

            throw new NotImplementedException();


        }

        public IEnumerable<Product> GetFilteredProducts(ShelterFilter shelterFilter)
        {
            
            throw new NotImplementedException();
        }


    }
}
