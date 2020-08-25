using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Services
{
    public class ReceitasServices : IReceitasServices
    {
        private readonly IReceitasRepository receitasRepository;
        public ReceitasServices(IReceitasRepository _receitasRepository)
        {
            receitasRepository = _receitasRepository;
        }
        public async Task<int> createAssync(Receitas entity)
        {
            return await receitasRepository.createAssync(entity);
        }

        public async Task<bool> deleteAssync(int id)
        {
            return await receitasRepository.deleteAssync(id);
        }

        public async Task<IEnumerable<Receitas>> readAllAssync()
        {
            return await receitasRepository.readAllAssync();
        }

        public async Task<Receitas> readOneAssync(int id)
        {
            return await receitasRepository.readOneAssync(id);
        }

        public async Task<bool> updateAssync(Receitas entity)
        {
            return await receitasRepository.updateAssync(entity);
        }
    }
}
