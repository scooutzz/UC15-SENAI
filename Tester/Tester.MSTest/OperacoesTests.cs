using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tester.Core;
namespace Tester.MSTest
{
    // classe de testes que voc� queira executar
    [TestClass]
    public class OperacoesTests
    {
        // m�todo de teste
        [TestMethod]
        // descricao do teste
        public void SomarDoisNumeros_RetornaResultado()
        {
            // arrange � organizar, preparar o teste
            double primeiroNumero = 10;
            double segundoNumero = 20;
            // act � agir � execu��o/chamada do m�todo
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Assert � comportamento esperado, comportamento obtido
            Assert.AreEqual(30, resultado);
        }
    }
}