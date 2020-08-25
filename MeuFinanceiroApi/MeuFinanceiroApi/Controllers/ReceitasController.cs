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
    public class ReceitasController : ControllerBase, IReceitasController
    {
        private readonly IReceitasServices receitasServices;
        public ReceitasController(IReceitasServices _receitasServices)
        {
            receitasServices = _receitasServices;
        }

        /// <summary>
        /// Atualiza as infomações de uma Receita já existente.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Cria uma nova Receita.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Remove uma Receitas infomando seu Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna uma lista com todas as Receitas cadastradas.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Retorna somente uma Receita de acordo com o Id informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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