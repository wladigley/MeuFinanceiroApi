using MeuFinanceiroApi.Controllers.Interfaces;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase,IDespesasController
    {
        private readonly IDespesasServices despesasServices;
        public DespesasController(IDespesasServices _despesasServices)
        {
            despesasServices = _despesasServices;
        }
        [HttpPut("atualizar")]
        public Task<IActionResult> AtualizarAssync([FromBody]Despesas entity)
        {
            throw new NotImplementedException();
        }
        [HttpPost("criar")]
        public Task<IActionResult> CriarAssync([FromBody]Despesas entity)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("remover/{id}")]
        public Task<IActionResult> RemoverAssync(int id)
        {
            throw new NotImplementedException();
        }
        [HttpGet("retornar-todos")]

        public Task<ActionResult<IEnumerable<Despesas>>> RetornarTodasAssync()
        {
            throw new NotImplementedException();
        }
        [HttpGet("retornar-um/{id}")]
        public Task<ActionResult<Despesas>> RetornarUmaAssync(int id)
        {
            throw new NotImplementedException();
        }
    }
}