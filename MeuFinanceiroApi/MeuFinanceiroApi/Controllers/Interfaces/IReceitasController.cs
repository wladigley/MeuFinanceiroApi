using MeuFinanceiroApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Controllers.Interfaces
{
    public interface IReceitasController
    {
        Task<IActionResult> CriarAssync(Receitas entity);
        Task<ActionResult<IEnumerable<Receitas>>> RetornarTodasAssync();
        Task<ActionResult<Receitas>> RetornarUmaAssync(int id);
        Task<IActionResult> AtualizarAssync(Receitas entity);
        Task<IActionResult> RemoverAssync(int id);
    }
}
