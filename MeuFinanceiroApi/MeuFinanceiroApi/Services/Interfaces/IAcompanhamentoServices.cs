using MeuFinanceiroApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Services.Interfaces
{
    public interface IAcompanhamentoServices
    {
        Task<Acompanhamento> GetAcompanhamentoFinaceiro();
    }
}
