using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories.Interfaces;
using MeuFinanceiroApi.Services.Interfaces;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Services
{
    public class AcompanhamentoServices : IAcompanhamentoServices
    {
        private readonly IAcompanhamentoRepository acompanhamentoRepository;
        public AcompanhamentoServices(IAcompanhamentoRepository _acompanhamentoRepository)
        {
            acompanhamentoRepository = _acompanhamentoRepository;
        }
        public async Task<Acompanhamento> GetAcompanhamentoFinaceiro()
        {
            return await acompanhamentoRepository.GetAcompanhamentoFinaceiro();
        }
    }
}
