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
    public class AcompanhamentoController : ControllerBase, IAcompanhamentoController
    {
        private readonly IAcompanhamentoServices acompanhamentoServices;
        public AcompanhamentoController(IAcompanhamentoServices _acompanhamentoServices)
        {
            acompanhamentoServices = _acompanhamentoServices;
        }
        /// <summary>
        /// Retorna as informações atualizadas das Despesas, Receitas e Saldos.
        /// </summary>
        /// <returns></returns>
        [HttpGet("meu-financeiro")]
        public async Task<ActionResult<Acompanhamento>> InfomacaoesFinanceiras()
        {
            try
            {
                var result = await acompanhamentoServices.GetAcompanhamentoFinaceiro();
                return Success(result);
            }
            catch (Exception ex)
            {
                return Error(ex, ex.Message.Contains('|') ? ex.Message : null);
            }
        }
    }
}