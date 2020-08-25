using System.Data;
using System.Data.SqlClient;

namespace MeuFinanceiroApi.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private string _connectionString { get; set; }
        private IDbConnection _dbConnection;

        public ConnectionFactory(string Server, string DataBase, string User, string Password)
        {
            _connectionString = $"Data Source={Server};Initial Catalog={DataBase};User ID={User};Password={Password}";
            _dbConnection = new SqlConnection(_connectionString);
        }

        public string GetConnectionString()
        {
            return _connectionString;
        }
        public IDbConnection GetDbConnectionOpened()
        {
            _dbConnection.Open();
            return _dbConnection;
        }
        public IDbConnection GetDbConnection()
        {
            return _dbConnection;
        }
    }
}
