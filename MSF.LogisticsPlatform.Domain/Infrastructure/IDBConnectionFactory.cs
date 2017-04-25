using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MSF.LogisticsPlatform.Domain.Infrastructure
{
    public interface IDBConnectionFactory
    {
        IDbConnection Connection { get;  }
    }
}
