using Microsoft.VisualStudio.TestTools.UnitTesting;

using sumador;

namespace Sumador.Test
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void TestSumarDosNumeros()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.sumar(6, 4);

            Assert.AreEqual(10, resultado);
                      
        }

        [TestMethod]
        public void TestSumarDosNumerosNegativos()
        {
            Calculadora calculadora = new Calculadora();

            int resultado = calculadora.sumar(-6, 4);

            Assert.AreEqual(-2, resultado);

        }
    }
}
