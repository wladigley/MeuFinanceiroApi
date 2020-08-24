using System.Data;

namespace MeuFinanceiroApi.Data
{
    public interface IConnectionFactory
    {
        string GetConnectionString();
        IDbConnection GetDbConnectionOpened();
        IDbConnection GetDbConnection();
    }
}
