using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.Tests
{
    [TestClass]
    public class DetalleVentaTests
    {
        [TestMethod]
        public void Subtotal_DeberiaCalcularCorrectamente()
        {
            // Arrange: Preparo los datos
            var libro = new Libro
            {
                IdLibro = 1,
                Titulo = "Programación en C",
                Autor = "K&R",
                Precio = 2500
            };

            var detalle = new DetalleVenta(1, libro, 2, 2400); // PrecioUnitario * Cantidad = 4800

            // Act: llamo al método que quiero probar
            var resultado = detalle.Subtotal();

            // Assert: verifico que el resultado sea el esperado
            Assert.AreEqual(4800, resultado);
        }
    }
}

