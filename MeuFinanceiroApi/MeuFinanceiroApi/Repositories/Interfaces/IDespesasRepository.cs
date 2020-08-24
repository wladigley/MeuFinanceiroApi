using MeuFinanceiroApi.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Repositories.Interfaces
{
    public interface IDespesasRepository//:IOperational<Despesas>
    {
        Task<int> createAssync(Despesas entity);
        Task<IEnumerable<Despesas>> readAllAssync();
        Task<Despesas> readOneAssync(int id);
        Task<bool> updateAssync(Despesas entity);
        Task deleteAssync(int id);

    }
}
