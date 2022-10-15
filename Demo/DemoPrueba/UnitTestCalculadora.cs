using DemoLibreria;

namespace DemoPrueba
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestSuma()
        {
            // Definimos las variables, Arrange
            var operador1 = 5;
            var operador2 = 7;

            // Ejecutamos la prueba, Act
            var result = Calculadora.sumar(operador1, operador2);

            // Comprobamos los resultados, Assert
            var valorEsperado = 12;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestResta()
        {
            // Definimos las variables, Arrange
            var operador1 = 7;
            var operador2 = 5;

            // Ejecutamos la prueba, Act
            var result = Calculadora.restar(operador1, operador2);

            // Comprobamos los resultados, Assert
            var valorEsperado = 2;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestMultiplicar()
        {
            // Definimos las variables, Arrange
            var operador1 = 7;
            var operador2 = 5;

            // Ejecutamos la prueba, Act
            var result = Calculadora.multiplicar(operador1, operador2);

            // Comprobamos los resultados, Assert
            var valorEsperado = 35;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestDividir()
        {
            // Definimos las variables, Arrange
            var operador1 = 10;
            var operador2 = 5;

            // Ejecutamos la prueba, Act
            var result = Calculadora.dividir(operador1, operador2);

            // Comprobamos los resultados, Assert
            var valorEsperado = 2;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestDividirExcepcion()
        {
            // Definimos las variables, Arrange
            var operador1 = 10;
            var operador2 = 0;

            // Ejecutamos la prueba, Act
            var result = Calculadora.dividir(operador1, operador2);

            // Comprobamos los resultados, Assert
            var valorEsperado = -1;
            Assert.AreEqual(valorEsperado, result);
        }
    }
}