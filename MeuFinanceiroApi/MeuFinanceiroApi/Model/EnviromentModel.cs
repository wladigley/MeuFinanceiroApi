using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Model
{
    public class EnviromentModel
    {
        public DataBaseParameters DataBaseParameters;
        public EnviromentModel()
        {
            DataBaseParameters _dbParams = new DataBaseParameters();
            _dbParams.Server = Environment.GetEnvironmentVariable("Server");
            _dbParams.DataBase = Environment.GetEnvironmentVariable("DataBase");
            _dbParams.User = Environment.GetEnvironmentVariable("User");
            _dbParams.Password = Environment.GetEnvironmentVariable("Password");
            DataBaseParameters = _dbParams;
        }
    
    }
    public class DataBaseParameters
    {
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
