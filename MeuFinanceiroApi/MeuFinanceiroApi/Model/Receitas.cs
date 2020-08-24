using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Model
{
    public class Receitas
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public bool Recebido { get; set; }
    }
}
