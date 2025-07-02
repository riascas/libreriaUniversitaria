using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.Test
{
    [TestClass]
    public class EmpleadoLoginTest
    {
        private EmpleadoBLL empleadoBLL;

        [TestInitialize]
        public void Inicializar()
        {
            empleadoBLL = new EmpleadoBLL();
        }

        [TestMethod]
        public void Login_Correcto_DeberiaDevolverEmpleado()
        {
            // Arrange
            int dni = 12345678; // Asegurate de que este DNI exista en Persona
            string clave = "admin123"; // Y que esta clave exista en Empleado

            // Act
            Empleado resultado = empleadoBLL.ValidarLogin(dni, clave);

            // Assert
            Assert.IsNotNull(resultado, "El empleado no fue encontrado, pero debería existir.");
            Assert.AreEqual(dni, resultado.Dni);
            Assert.AreEqual(clave, resultado.Clave);
        }

        [TestMethod]
        public void Login_Incorrecto_DeberiaDevolverNull()
        {
            // Arrange
            int dni = 44444444;
            string clave = "claveIncorrecta";

            // Act
            Empleado resultado = empleadoBLL.ValidarLogin(dni, clave);

            // Assert
            Assert.IsNull(resultado, "El empleado no debería existir con estos datos.");
        }
    }
}
