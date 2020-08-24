namespace MeuFinanceiroApi.Repositories.Scripts
{
    public class DespesasScripts
    {
        public static string INSERT_SINGLE_DESPESAS => "INSERT INTO Despesas OUTPUT INSERTED.ID (Descricao, valor, Data, Pago) values (@Descricao, @valor, @Data, @Pago)";
    }
}
