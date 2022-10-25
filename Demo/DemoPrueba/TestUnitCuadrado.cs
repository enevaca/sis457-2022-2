using DemoLibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrueba
{
    [TestClass]
    public class TestUnitCuadrado
    {
        [TestMethod]
        public void TestArea()
        {
            // Definimos las variables, Arrange
            var lado = 5;

            // Ejecutamos la prueba, Act
            var cuadrado = new Cuadrado(lado);
            var result = cuadrado.area();

            // Comprobamos los resultados, Assert
            var valorEsperado = 25;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestPerimetro()
        {
            // Definimos las variables, Arrange
            var lado = 5;

            // Ejecutamos la prueba, Act
            var cuadrado = new Cuadrado(lado);
            var result = cuadrado.perimetro();

            // Comprobamos los resultados, Assert
            var valorEsperado = 20;
            Assert.AreEqual(valorEsperado, result);
        }
    }
}
