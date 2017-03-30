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
            //Chen's connectionString
            connectionString = "Data Source=DESKTOP-O942SQF\\SQLEXPRESS;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //connectionString ="your connection string from SQL Server Objcect Explorer inside Visual Studio";
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
