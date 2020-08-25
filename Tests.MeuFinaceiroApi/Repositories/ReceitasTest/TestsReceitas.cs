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

namespace Tests.MeuFinaceiroApi.Repositories.ReceitasTest
{
    public class TestsReceitas
    {
        private static ReceitasRepository receitasRepository;
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

        public static IEnumerable<object[]> MockListReceitas()
        {
            yield return new[] { new Receitas { Descricao = "Emprestimo Devolvido", Valor=500, Data=DateTime.Now, Recebido =true} };
            yield return new[] { new Receitas { Descricao = "venda do celular", Valor=650, Data=DateTime.Now, Recebido =true} };
            yield return new[] { new Receitas { Descricao = "grana do freela", Valor=650, Data=DateTime.Now, Recebido =false} };
        }
        public TestsReceitas()
        {
            var factoryMock = new Mock<IConnectionFactory>();
            factoryMock
                .Setup(cf => cf.GetDbConnectionOpened())
                .Returns(CreateConnectionMock);

            dbConnectionFactory = factoryMock.Object;
            receitasRepository = new ReceitasRepository(dbConnectionFactory);
        }

        [Theory(DisplayName ="CRIAR uma Receitas.")]
        [MemberData(nameof(MockListReceitas))]
        public void createAssync(Receitas Receitas)
        {
            var result = receitasRepository.createAssync(Receitas).Result;
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "DELETAR uma Receitas.")]
        public void deleteAssync()
        {
            var result = receitasRepository.deleteAssync(0).Result;
        }

        [Fact(DisplayName = "RETORNAR TODAS Receitas.")]
        public void readAllAssync()
        {
            var result = receitasRepository.readAllAssync().Result;
        }

        [Fact(DisplayName = "RETORNAR UMA Receitas.")]
        public void readOneAssync()
        {
            var result = receitasRepository.readOneAssync(0).Result;
        }

        [Fact(DisplayName = "ATUALIZAR UMA Receitas.")]

        public void updateAssync()
        {
            var result = receitasRepository.updateAssync(null).Result;
        }
    }
}
