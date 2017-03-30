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

        public async Task<IEnumerable<ProductFiles>> GetAll()
        {
            //var sql = @"SELECT ProductFile, Product.ProductId, ProductName FROM ProductFiles INNER JOIN Product ON ProductFiles.ProductId = Product.ProductId";
            var sql = @"SELECT ProductFiles.ProductFile, ProductFiles.ProductId, Product.ProductId, Product.ProductName FROM ProductFiles INNER JOIN Product ON Product.ProductId =ProductFiles.ProductId WHERE ProductFiles.FileExtention='jpg'";
            using (IDbConnection conn = _dbConnectionFactory.connection)
            {
                conn.Open();
                return await conn.QueryAsync<ProductFiles, Product, ProductFiles>(sql,
                    (productfile, product) => { productfile.Product = product; return productfile; }, commandType: CommandType.Text, splitOn: "ProductId");                
            }
        }     
    }
}
