using MeuFinanceiroApi.Data;
using MeuFinanceiroApi.Model;
using MeuFinanceiroApi.Repositories;
using MeuFinanceiroApi.Repositories.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.MeuFinaceiroApi.Repositories.DespesasTest
{
    public class TestsDespesas
    {
        private static DespesasRepository despesasRepository;
        private IConnectionFactory dbConnectionFactory;

        private IDbConnection CreateConnectionMock()
        {
            var Server = "localhost";
            var database = "MeuFinanceiro";
            var user = "sa";
            var password = "245809";

            var connection = new SqlConnection($"Server={Server};Database={database};User Id={user};Password={password}");
            connection.Open();

            return connection;
        }

        public static IEnumerable<object[]> MockListDespesas()
        {
            yield return new[] { new Despesas { Descricao = "Pagar o Carro", Valor=650, Data=DateTime.Now, Pago =true} };
            yield return new[] { new Despesas { Descricao = "Pagar a Barbearia", Valor=650, Data=DateTime.Now, Pago =true} };
            yield return new[] { new Despesas { Descricao = "Pagar Almoço", Valor=650, Data=DateTime.Now, Pago =false} };
            yield return new[] { new Despesas { Descricao = "Compras de Roupas", Valor=650, Data=DateTime.Now, Pago =true} };
        }
        public TestsDespesas()
        {
            var factoryMock = new Mock<IConnectionFactory>();
            factoryMock
                .Setup(cf => cf.GetDbConnectionOpened())
                .Returns(CreateConnectionMock);

            dbConnectionFactory = factoryMock.Object;
            despesasRepository = new DespesasRepository(dbConnectionFactory);
        }

        [Theory(DisplayName ="CRIAR uma Despesas.")]
        [MemberData(nameof(MockListDespesas))]
        public void createAssync(Despesas despesas)
        {
            var result = despesasRepository.createAssync(despesas).Result;
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "DELETAR uma Despesas.")]
        public void deleteAssync()
        {
            var result = despesasRepository.deleteAssync(0).Result;
        }

        [Fact(DisplayName = "RETORNAR TODAS Despesas.")]
        public void readAllAssync()
        {
            var result = despesasRepository.readAllAssync().Result;
        }

        [Fact(DisplayName = "RETORNAR UMA Despesas.")]
        public void readOneAssync()
        {
            var result = despesasRepository.readOneAssync(0).Result;
        }

        [Fact(DisplayName = "ATUALIZAR UMA Despesas.")]

        public void updateAssync()
        {
            var result = despesasRepository.updateAssync(null).Result;
        }
    }
}
