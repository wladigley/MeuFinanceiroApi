using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Repositories.Scripts
{
    public class ReceitasScripts
    {
        public static string INSERT_SINGLE_RECEITAS => "INSERT INTO Receitas (Descricao, valor, Data, Recebido) OUTPUT INSERTED.ID values (@Descricao, @valor, @Data, @Recebido)";
    }
}
