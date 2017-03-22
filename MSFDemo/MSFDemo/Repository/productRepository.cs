using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSFDemo.Models;
using MSFDemo.Repository;
using Dapper;
using System.Data;
using System.Data.SqlClient;

//using 


namespace MSFDemo.Repository
{
    public class productRepository : IProductRepository
    {
        private string connectionString;
        public productRepository()
        {
            connectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Test01;Integrated Security=True";
        }
        //(localdb)\MSSQLLocalDB;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
        //Show a single product details
        public Product GetByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "SELECT * FROM productMSF"
                               + " WHERE ID = @Id";
                dbConnection.Open();
                return dbConnection.Query<Product>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }
        public IEnumerable<Product> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Product>("SELECT * FROM productMSF");
            }
        }
        public void Add(Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "INSERT INTO productMSF (Name, Quantity, ProductTypeId, DateCreated, bActive,rowGUID)"
                                + " VALUES(@Name, @Quantity, @ProductTypeId, @DateCreated, @bActive, @newid())";
                dbConnection.Open();
                dbConnection.Execute(sQuery, prod);
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "DELETE FROM productMSF"
                             + " WHERE ID = @Id";
                dbConnection.Open();
                dbConnection.Execute(sQuery, new { Id = id });
            }
        }

        public void Update(Product prod)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string sQuery = "UPDATE ProductMSF SET Name = @Name,"
                               + " Quantity = @Quantity, Price= @Price,Image=@Image"
                               + " WHERE ProductId = @ProductId";
                dbConnection.Open();
                dbConnection.Query(sQuery, prod);
            }
        }
    }

}
    

