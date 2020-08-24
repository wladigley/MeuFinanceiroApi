using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Services
{
    public class DespesasServices : IDespesasServices
    {
        private readonly IDespesasRepository despesasRepository;
        public DespesasServices(IDespesasRepository _despesasRepository)
        {
            despesasRepository = _despesasRepository;
        }
        public async Task<int> createAssync(Despesas entity)
        {
           return await despesasRepository.createAssync(entity);
        }

        public async Task deleteAssync(int id)
        {
            await despesasRepository.deleteAssync(id);
        }

        public async Task<IEnumerable<Despesas>> readAllAssync()
        {
            return await despesasRepository.readAllAssync();
        }

        public async Task<Despesas> readOneAssync(int id)
        {
            return await despesasRepository.readOneAssync(id);
        }

        public async Task<bool> updateAssync(Despesas entity)
        {
            return await despesasRepository.updateAssync(entity);
        }
    }
}
