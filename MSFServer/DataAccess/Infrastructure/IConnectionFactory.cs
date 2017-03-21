using System.Data;

namespace DataAccess.Infrastructure
{
    public interface IConnectionFactory
    {
        IDbConnection Connection { get; }
    }
}