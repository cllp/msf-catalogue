using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Dapper;
using System.Data;
using Npgsql;
using MSF.Catalogue.Models;
 
namespace MSF.Catalogue.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private string connectionString = "User ID=postgres;Password=lillHH77;Host=localhost;Port=5432;Database=test;Pooling=true;";
        //public ProductRepository(IConfiguration configuration)

        public ProductRepository()
        {
            //connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
            //connectionString = configuration.GetValue<string>("User ID=postgres;Password=lillHH77;Host=localhost;Port=5432;Database=test;Pooling=true;");
        }
 
        internal IDbConnection Connection
        {
            get
            {
                return new NpgsqlConnection(connectionString);
            }
        }
 
        public int Add(Product item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                
                string sql = @"
                INSERT INTO Product (name, created) VALUES(@Name, @created);
                SELECT max(id) from Product";

                dbConnection.Open();
                return dbConnection.Query<int>(sql, item).Single();

                //dbConnection.Open();
                //return dbConnection.Execute("INSERT INTO Product (name, created) VALUES(@Name, @created)", item);

            }
 
        }
 
        public IEnumerable<Product> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>("SELECT * FROM Product");
            }
        }
 
        public Product FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>("SELECT * FROM Product WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }
 
        public void Remove(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Execute("DELETE FROM Product WHERE Id=@Id", new { Id = id });
            }
        }
 
        public void Update(Product item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.Query("UPDATE Product SET name = @Name WHERE id = @Id", item);
            }
        }
    }
}
