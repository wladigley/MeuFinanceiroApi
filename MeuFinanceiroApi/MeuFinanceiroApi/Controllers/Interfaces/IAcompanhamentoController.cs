using MeuFinanceiroApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Controllers.Interfaces
{
    public interface IAcompanhamentoController
    {
        Task<ActionResult<Acompanhamento>> InfomacaoesFinanceiras();
    }
}
