using Nutrivitta;
using System;
using Xunit;

namespace TestXUnitIMC
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularIMC()
        {
            // Arrange
            double peso = 0;
            double altura = 0;
            string resultadoEsperado = "Peso e/ou altura não podem ser negativos ou ter valores iguais a zero(0).";

            // Act
            var resultadoObtido = CalculadoraImc.ClassificacaoIMC(peso, altura);

            // Asssert
            Assert.Equal(resultadoEsperado, resultadoObtido);
        }

        [Theory]
        [InlineData(-3, 0, "Peso e/ou altura não podem ser negativos ou ter valores iguais a zero(0).")]
        [InlineData(70, 1.75, "IMC: 22,86 kgm²\nPeso normal")]
        [InlineData(63, 1.85, "IMC: 18,41 kgm²\nAbaixo do peso")]
        [InlineData(78, 1.65, "IMC: 28,65 kg/m²\nSobrepeso")]
        [InlineData(60, 1.40, "IMC: 30,61 kg/m²\nObesidade grau I")]
        [InlineData(90, 1.60, "IMC: 35,16 kg/m²\nObesidade grau II")]
        [InlineData(140, 1.80, "IMC: 43,21 kg/m²\nObesidade grau III")]

        public void CalcularImcLista(double peso, double altura, string resultadoEsperado)
        {
            var resultadoObtido = CalculadoraImc.ClassificacaoIMC(peso, altura);

            Assert.Equal(resultadoEsperado, resultadoEsperado);
        }
    }
}