using Dapper;
using Dapper.FastCrud;
using MeuFinanceiroApi.Data;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Repositories.Scripts;
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

        public async Task<int> createAssync(Despesas entity)
        {
            // Poderia ser utilizado o Insert() do fastcrud, porém retorna void(), e quero que retorne o id inserido
            // também podeira usar dapper.contrib que retorna o id da linha inserida, mas não optei por instalar mais uma biblioteca.
            return await _dbConnenction.ExecuteAsync(DespesasScripts.INSERT_SINGLE_DESPESAS, entity);
        }

        public async Task<bool> deleteAssync(int id)
        {
            return await _dbConnenction.DeleteAsync(new Despesas { Id = id });
        }

        public async Task<IEnumerable<Despesas>> readAllAssync()
        {
            return await _dbConnenction.FindAsync<Despesas>();
        }

        public async Task<Despesas> readOneAssync(int id)
        {
            return await _dbConnenction.GetAsync(new Despesas { Id = id });
        }

        public async Task<bool> updateAssync(Despesas entity)
        {
            return await _dbConnenction.UpdateAsync(entity);
        }
    }
}
