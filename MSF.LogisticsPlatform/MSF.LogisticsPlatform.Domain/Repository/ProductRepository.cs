using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Text;
using MSF.LogisticsPlatform.Domain.Entities;
using MSF.LogisticsPlatform.Domain.Infrastructure;
namespace MSF.LogisticsPlatform.Domain.Repository
  
{
    public class ProductRepository
    {
        IDBConnectionFactory _dbconnectionFactory;
        public ProductRepository(IDBConnectionFactory dbconnectionFactory)
        {
            _dbconnectionFactory = dbconnectionFactory;
        }
        public IEnumerable<Product> GetAll()
        {
            using (IDbConnection conn = _dbconnectionFactory.connection)
            {
                conn.Open();
                return conn.Query<Product>("Select * from Product");
            }
        }
    }
}
