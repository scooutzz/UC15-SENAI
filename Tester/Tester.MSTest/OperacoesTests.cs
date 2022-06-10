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
            double resultadoNumero = 30;
            // act � agir � execu��o/chamada do m�todo
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);
            // Assert � comportamento esperado, comportamento obtido
            Assert.AreEqual(resultadoNumero, resultado);
        }


        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]  // erro proposital
        public void SomarDoisNumerosLista(double primeiroNumero, double segundoNumero, double resultadoNumero)
        {

            // Act
            var resultado = Operacoes.Somar(primeiroNumero, segundoNumero);

            // Assert
            Assert.AreEqual(resultadoNumero, resultado);
        }

    }
}