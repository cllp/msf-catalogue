using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public class ProductRepository
    {
        public string connectionString;

        public ProductRepository()
        {
            //connectionString = "Data Source=MMA-4CZ13909R0; SQLEXPRESS01;Initial Catalog=MIC_Data;Integrated Security=True";
            //connectionString = @"Server = (localdb)\\mssqllocaldb; SQLEXPRESS; Database = MIC_Data; Trusted_Connection = True; MultipleActiveResultSets = true";
            connectionString = "Data Source=MMA-4CZ13909R0\\SQLEXPRESS01;Initial Catalog=MIC_Data;Integrated Security=True";

        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
              return dbConnection.Query<Product>("SELECT PRODUCTTYPEID,PRODUCTNAME FROM PRODUCT");
            }
        }
    }
}
