using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tester.Core;
namespace Tester.MSTest
{
    // classe de testes que você queira executar
    [TestClass]
    public class OperacoesTests
    {
        // método de teste
        [TestMethod]
        // descricao do teste
        public void SomarDoisNumeros_RetornaResultado()
        {
            // arrange – organizar, preparar o teste
            double primeiroNumero = 10;
            double segundoNumero = 20;
            // act – agir – execução/chamada do método
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Assert – comportamento esperado, comportamento obtido
            Assert.AreEqual(30, resultado);
        }
    }
}