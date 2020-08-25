using MeuFinanceiroApi.Controllers.Interfaces;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static MeuFinanceiroApi.Model.ResultView;

namespace MeuFinanceiroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase, IDespesasController
    {
        private readonly IDespesasServices despesasServices;
        public DespesasController(IDespesasServices _despesasServices)
        {
            despesasServices = _despesasServices;
        }

        [HttpPut("atualizar")]
        public async Task<IActionResult> AtualizarAssync([FromBody]Despesas entity)
        {
            try
            {
                var result = await despesasServices.updateAssync(entity);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }


        [HttpPost("criar")]
        public async Task<IActionResult> CriarAssync([FromBody]Despesas entity)
        {
            try
            {
                var result = await despesasServices.createAssync(entity);
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
            try
            {
                var result = await despesasServices.deleteAssync(id);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }


        [HttpGet("retornar-todos")]
        public async Task<ActionResult<IEnumerable<Despesas>>> RetornarTodasAssync()
        {
            try
            {
                var result = await despesasServices.readAllAssync();
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }


        [HttpGet("retornar-um/{id}")]
        public async Task<ActionResult<Despesas>> RetornarUmaAssync(int id)
        {
            try
            {
                var result = await despesasServices.readOneAssync(id);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }
    }
}