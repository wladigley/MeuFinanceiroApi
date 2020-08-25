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
    public class ReceitasRepository : IReceitasRepository
    {
        private readonly IDbConnection _dbConnenction;
        public ReceitasRepository(IConnectionFactory conn)
        {
            _dbConnenction = conn.GetDbConnectionOpened();
        }
        public async Task<int> createAssync(Receitas entity)
        {
            using (var conn = _dbConnenction)
            {
                // Poderia ser utilizado o Insert() do fastcrud, porém retorna void(), e quero que retorne o id inserido
                // também podeira usar dapper.contrib que retorna o id da linha inserida, mas não optei por instalar mais uma biblioteca.
                return await conn.ExecuteScalarAsync<int>(ReceitasScripts.INSERT_SINGLE_RECEITAS, entity);
            }
        }

        public async Task<bool> deleteAssync(int id)
        {
            using (var conn = _dbConnenction)
            {
                return await conn.DeleteAsync(new Receitas { Id = id });
            }
        }

        public async Task<IEnumerable<Receitas>> readAllAssync()
        {
            using (var conn = _dbConnenction)
            {
                return await conn.FindAsync<Receitas>();
            }
        }

        public async Task<Receitas> readOneAssync(int id)
        {
            using (var conn = _dbConnenction)
            {
                return await conn.GetAsync(new Receitas { Id = id });
            }
        }

        public async Task<bool> updateAssync(Receitas entity)
        {
            using (var conn = _dbConnenction)
            {
                return await conn.UpdateAsync(entity);
            }
        }
    }
}
