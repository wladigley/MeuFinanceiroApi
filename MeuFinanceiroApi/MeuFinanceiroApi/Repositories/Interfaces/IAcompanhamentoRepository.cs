using MeuFinanceiroApi.Model;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Repositories.Interfaces
{
    public interface IAcompanhamentoRepository
    {
        Task<Acompanhamento> GetAcompanhamentoFinaceiro();
    }
}
