namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(5, CalculadoraExemplo.Calculadora.Somar(2, 3));
            Assert.Equal(2, CalculadoraExemplo.Calculadora.Subtrair(4, 2));
            Assert.Equal(6, CalculadoraExemplo.Calculadora.Multiplicar(2, 3));
            Assert.Equal(2, CalculadoraExemplo.Calculadora.Dividir(4, 2));
        }
    }
}                                                                         