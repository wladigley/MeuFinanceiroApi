namespace MeuFinanceiroApi.Repositories.Scripts
{
    public class AcompanhamentoScripts
    {
        public static string SELECT_ACOMPANHAMENTO => $@"
            SELECT 
                rc.TotalReceitas,
                td.TotalDespesas,
                (rc.TotalReceitas-td.TotalDespesas) AS SaldoTotal 
            FROM
                (SELECT SUM(valor) AS TotalReceitas FROM Receitas ) AS rc
            JOIN
                 (SELECT SUM(valor) AS TotalDespesas FROM Despesas ) As td
            ON 1=1
        ";
    }
}
