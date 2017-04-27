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
        //For local DB connection change the connectionString in Sql Server Object Explorer in VS.
        //private readonly string connectionString = @"Data Source=JAYWAY-PC;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //The following string is used to connent to Azure SQL server.
        private readonly string connectionString = @"Server=tcp:twb3server.database.windows.net,1433;Initial Catalog = TWB3; Persist Security Info=False;User ID =  MATS.WEIDMAR ; Password= HackademyRulezOk!; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";

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

