using FacundoGiannone.Entidades;
using System.ComponentModel.DataAnnotations;

namespace FacundoGiannone.Testing
{
    [TestClass]
    public class PiramideCuadradaTest
    {
        [TestMethod]
        public void CalcularApotemaTest()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double apotema = piramide.CalcularApotema();

            // Assert
            Assert.AreEqual(12.36931687685298, apotema, 0.0001);
        }

        [TestMethod]
        public void CalcularAreaTest()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double area = piramide.CalcularArea();

            // Assert
            Assert.AreEqual(184.43180252223578, area, 0.0001);
        }

        [TestMethod]
        public void CalcularVolumenTest()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double volumen = piramide.CalcularVolumen();

            // Assert
            Assert.AreEqual(144.0, volumen, 0.0001);
        }

        [TestMethod]
        public void ValidarTest()
        {
            // Arrange
            var piramide = new PiramideCuadrada(-5, -10);
            var context = new ValidationContext(piramide);
            var errores = new List<ValidationResult>();

            // Act
            bool esValido = Validator.TryValidateObject(piramide, context, errores, true);

            // Assert
            Assert.IsFalse(esValido);
            Assert.IsTrue(errores.Count > 0);
        }
    }
}
