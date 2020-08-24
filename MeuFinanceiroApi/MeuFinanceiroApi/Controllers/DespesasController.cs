using MeuFinanceiroApi.Controllers.Interfaces;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MeuFinanceiroApi.Model.ResultView;

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
        public async Task<IActionResult> AtualizarAssync([FromBody]Despesas entity)
        {
            throw new NotImplementedException();
        }
        [HttpPost("criar")]
        public async Task<IActionResult> CriarAssync([FromBody]Despesas entity)
        {
            try
            {
                var result = despesasServices.createAssync(entity);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }
        [HttpDelete("remover/{id}")]
        public async Task<IActionResult> RemoverAssync(int id)  
        {
            throw new NotImplementedException();
        }
        [HttpGet("retornar-todos")]

        public async Task<ActionResult<IEnumerable<Despesas>>> RetornarTodasAssync()
        {
            throw new NotImplementedException();
        }
        [HttpGet("retornar-um/{id}")]
        public async Task<ActionResult<Despesas>> RetornarUmaAssync(int id)
        {
            throw new NotImplementedException();
        }
    }
}