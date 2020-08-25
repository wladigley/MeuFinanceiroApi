using Dapper;
using MeuFinanceiroApi.Data;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Repositories.Scripts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Repositories
{
    public class AcompanhamentoRepository : IAcompanhamentoRepository
    {
        private readonly IDbConnection _dbConnenction;
        public AcompanhamentoRepository(IConnectionFactory conn)
        {
            _dbConnenction = conn.GetDbConnectionOpened();
        }
        public async Task<Acompanhamento> GetAcompanhamentoFinaceiro()
        {
            using (var conn = _dbConnenction)
            {
                return await conn.QueryFirstAsync<Acompanhamento>(AcompanhamentoScripts.SELECT_ACOMPANHAMENTO);
            }
        }
    }
}
