using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Infrastucture
{
    public class DBConnectionFactory:IDBConnectionFactory,IDisposable
    {
        //To connent Azure SQL server just change the conn. String

        private readonly string connectionString = @"Data Source=JAYWAY-PC;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);

            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

