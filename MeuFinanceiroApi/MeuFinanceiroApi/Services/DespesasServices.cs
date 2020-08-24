using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task createAssync(Despesas entity)
        {
            await despesasRepository.createAssync(entity);
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

        public async Task updateAssync(Despesas entity)
        {
            await despesasRepository.updateAssync(entity);
        }
    }
}
