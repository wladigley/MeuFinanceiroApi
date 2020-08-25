using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuFinanceiroApi.Controllers.Interfaces;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static MeuFinanceiroApi.Model.ResultView;

namespace MeuFinanceiroApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase, IReceitasController
    {
        private readonly IReceitasServices receitasServices;
        public ReceitasController(IReceitasServices _receitasServices)
        {
            receitasServices = _receitasServices;
        }


        [HttpPut("atualizar")]
        public async Task<IActionResult> AtualizarAssync(Receitas entity)
        {
            try
            {
                var result = await receitasServices.updateAssync(entity);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }


        [HttpPost("criar")]
        public async Task<IActionResult> CriarAssync(Receitas entity)
        {
            try
            {
                var result = await receitasServices.createAssync(entity);
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
                var result = await receitasServices.deleteAssync(id);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }


        [HttpGet("retornar-todos")]
        public async Task<ActionResult<IEnumerable<Receitas>>> RetornarTodasAssync()
        {
            try
            {
                var result = await receitasServices.readAllAssync();
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }

        [HttpGet("retornar-um/{id}")]
        public async Task<ActionResult<Receitas>> RetornarUmaAssync(int id)
        {
            try
            {
                var result = await receitasServices.readOneAssync(id);
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }
    }
}