using Tester.Core;
using Xunit;
namespace Tester.XUnit
{
    public class OperacoesTests
    {
        // m�todo de teste
        [Fact]
        // descricao do teste
        public void SomarDoisNumeros_RetornaResultado()
        {
            // arrange � organizar, preparar o teste
            double primeiroNumero = 10;
            double segundoNumero = 20;
            // act � agir � execu��o/chamada do m�todo
            var resultado = Operacoes.Somar(primeiroNumero,
            segundoNumero);
            // Assert � comportamento esperado, comportamento obtido
            Assert.Equal(30, resultado);
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void SomarDoisNumeros_RetornaResultado_ParaUmaListaDeValores(double primeiroNumero, double segundoNumero, double resultadoEsperado)
        {
            var resultadoDaSoma = Operacoes.Somar(primeiroNumero,
            segundoNumero);
            Assert.Equal(resultadoEsperado, resultadoDaSoma);
        }
    }
}