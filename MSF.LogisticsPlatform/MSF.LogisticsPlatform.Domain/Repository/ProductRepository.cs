using System.Collections.Generic;
using System.Data;
using Dapper;
using MSF.LogisticsPlatform.Domain.Infrastructure;
using System.Threading.Tasks;
using MSF.LogisticsPlatform.Domain.Entities;


namespace MSF.LogisticsPlatform.Domain.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDBConnectionFactory _dbConnectionFactory;        

        public ProductRepository(IDBConnectionFactory dbconnectionFactory)
        {
            _dbConnectionFactory = dbconnectionFactory;
        }       

        /*public IEnumerable<Product> GetAll()
        {
            using (IDbConnection conn = _dbConnectionFactory.connection)
            {
                conn.Open();
                return conn.Query<Product>("Select * from Product");
            }
        }*/

        public async Task<IEnumerable<Product>> GetAll()
        {
            using (IDbConnection conn = _dbConnectionFactory.connection)
            {
                conn.Open();
                return await conn.QueryAsync<Product>("Select * from Product");
                //return await conn.QueryAsync<ProdFileView>("SELECT Pr.ProductName, Pf.ProductFile FROM Product AS Pr, ProductFiles AS Pf WHERE Pr.ProductId = Pf.ProductFile");
            }
        }

   }
}
