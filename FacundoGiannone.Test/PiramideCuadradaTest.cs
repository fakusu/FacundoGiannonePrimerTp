using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FacundoGiannone.Test
{
    [TestClass]
    public class PiramideCuadradaTest
    {
        [TestMethod]
        public void CalcularApotema_DatosValidos_RetornaApotemaCorrecta()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double apotema = piramide.CalcularApotema();

            // Assert
            Assert.AreEqual(8.48528137423857, apotema, 0.0001);
        }

        [TestMethod]
        public void CalcularArea_DatosValidos_RetornaAreaCorrecta()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double area = piramide.CalcularArea();

            // Assert
            Assert.AreEqual(347.6467529817257, area, 0.0001);
        }

        [TestMethod]
        public void CalcularVolumen_DatosValidos_RetornaVolumenCorrecto()
        {
            // Arrange
            var piramide = new PiramideCuadrada(6, 12);

            // Act
            double volumen = piramide.CalcularVolumen();

            // Assert
            Assert.AreEqual(288.0, volumen, 0.0001);
        }

        [TestMethod]
        public void Validar_ValoresNegativos_DevuelveErroresDeValidacion()
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

