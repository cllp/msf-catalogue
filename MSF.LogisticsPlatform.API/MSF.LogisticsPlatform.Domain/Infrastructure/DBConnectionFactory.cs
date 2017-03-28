using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Infrastructure
{
    public class DBConnectionFactory : IDBConnectionFactory
    {
        private string connectionString;

        public DBConnectionFactory()
        {
            connectionString = "Data Source=MMA-CZC202DLGP\\SQLEXPRESS;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public IDbConnection connection
        {
            get
            {
                return new SqlConnection(connectionString);

            }
        }

    }
    
}
