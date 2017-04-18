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
        //Server=tcp:twb3server.database.windows.net,1433;Initial Catalog=TWB3;Persist Security Info=False;User ID=mats.weidmar;Password=HackademyRulezOk!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";

        private readonly string connectionString = @"Data Source=MMA-4CZ13909R0\SQLEXPRESS01;Initial Catalog=MIC_Data;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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

