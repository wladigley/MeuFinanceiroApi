namespace MeuFinanceiroApi.Repositories.Scripts
{
    public class DespesasScripts
    {
        public static string INSERT_SINGLE_DESPESAS => "INSERT INTO Despesas (Descricao, valor, Data, Pago) OUTPUT INSERTED.ID values (@Descricao, @valor, @Data, @Pago)";
    }
}
