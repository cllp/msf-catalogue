
using System.Data;
using System.Data.Common;

namespace MSF.LogisticsPlatform.Domain.Infrastructure
{
    public interface IDBConnectionFactory
    {
        IDbConnection connection { get; }
    }
}