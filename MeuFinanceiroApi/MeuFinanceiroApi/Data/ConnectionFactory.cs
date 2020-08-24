using MeuFinanceiroApi.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Data
{
    public class ConnectionFactory
    {
        private string _connectionString { get; set; }
        private IDbConnection _dbConnection;
        private EnviromentModel model;
        public ConnectionFactory(EnviromentModel _envModel)
        {
            _dbConnection = new SqlConnection();
            model = _envModel;
            _connectionString = $"Data Source={model.DataBaseParameters.Server};Initial Catalog=Cosmos_v14b;Persist Security Info=True;User ID={model.DataBaseParameters.User};Password={model.DataBaseParameters.Password};";
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
