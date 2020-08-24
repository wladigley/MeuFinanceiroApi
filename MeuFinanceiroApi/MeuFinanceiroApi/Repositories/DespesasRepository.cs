using Dapper.FastCrud;
using MeuFinanceiroApi.Data;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Repositories
{
    public class DespesasRepository : IDespesasRepository
    {
        private readonly IDbConnection _dbConnenction;
        public DespesasRepository(ConnectionFactory conn)
        {
            _dbConnenction = conn.GetDbConnectionOpened();
        }

        public async Task createAssync(Despesas entity)
        {
            await _dbConnenction.InsertAsync(entity);
        }

        public async Task deleteAssync(int id)
        {
            await _dbConnenction.DeleteAsync(new Despesas { Id = id });
        }

        public async Task<IEnumerable<Despesas>> readAllAssync()
        {
            return await _dbConnenction.FindAsync<Despesas>();
        }

        public async Task<Despesas> readOneAssync(int id)
        {
            return await _dbConnenction.GetAsync(new Despesas{Id = id});
        }

        public async Task updateAssync(Despesas entity)
        {
            await _dbConnenction.UpdateAsync(entity);
        }
    }
}
