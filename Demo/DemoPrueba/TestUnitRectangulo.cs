using DemoLibreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrueba
{
    [TestClass]
    public class TestUnitRectangulo
    {
        [TestMethod]
        public void TestArea()
        {
            // Definimos las variables, Arrange
            var base_ = 5;
            var altura = 3;

            // Ejecutamos la prueba, Act
            var rectangulo = new Rectangulo(base_, altura);
            var result = rectangulo.area();

            // Comprobamos los resultados, Assert
            var valorEsperado = 15;
            Assert.AreEqual(valorEsperado, result);
        }

        [TestMethod]
        public void TestPerimetro()
        {
            // Definimos las variables, Arrange
            var base_ = 5;
            var altura = 3;

            // Ejecutamos la prueba, Act
            var rectangulo = new Rectangulo(base_, altura);
            var result = rectangulo.perimetro();

            // Comprobamos los resultados, Assert
            var valorEsperado = 16;
            Assert.AreEqual(valorEsperado, result);
        }
    }
}
