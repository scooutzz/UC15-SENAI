namespace Nutrivitta
{
    public static class CalculadoraImc
    {
        public static string ClassificacaoIMC(double peso, double altura)
        {
            if (peso <= 0 || altura <= 0)
            {
                return "Peso e/ou altura não podem ser negativos ou ter valores iguais a zero(0).";
            }

            double imc = peso / (altura * altura);
            string classificacao = "";

            if (imc < 18.5)
            {
                classificacao = "Abaixo do peso";
            }
            else if (imc < 25)
            {
                classificacao = "Peso normal";
            }
            else if (imc < 30)
            {
                classificacao = "Sobrepeso";
            }
            else if (imc < 40)
            {
                classificacao = "Obesidade grau I";
            }
            else if (imc < 40)
            {
                classificacao = "Obesidade grau II";
            }
            else if (imc >= 40)
            {
                classificacao = "Obesidade grau III";
            }

            return "IMC: {imc:0.00} kg/m²\n{classificacao}";
        }
    }
}