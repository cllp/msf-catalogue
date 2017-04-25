using MSF.LogisticsPlatform.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Infrastructure
{
    public class DBConnectionFactory:IDBConnectionFactory,IDisposable
    {
        //To connent Azure SQL server just change the conn. String
        //For local DB connection change the connectionString from Sql Server Object Explorer in VS.

        private readonly string connectionString = @"Data Source=MMA-CZC202DLGP\SQLEXPRESS;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

