using MeuFinanceiroApi.Intefaces;
using MeuFinanceiroApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Controllers.Interfaces
{
    public interface IDespesasController
    {
        Task<IActionResult> CriarAssync(Despesas entity);
        Task<ActionResult<IEnumerable<Despesas>>> RetornarTodasAssync();
        Task<ActionResult<Despesas>> RetornarUmaAssync(int id);
        Task<IActionResult> AtualizarAssync(Despesas entity);
        Task<IActionResult> RemoverAssync(int id);
    }
}
