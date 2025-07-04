using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.Test
{
    [TestClass]
    public class ClienteDALTest
    {
        [TestMethod]
        public void BuscarClientePorDni_DeberiaRetornarClienteExistente()
        {
            // Arrange: creamos la instancia del DAL y definimos un DNI que ya existe en la base
            ClienteDAL clienteDAL = new ClienteDAL();
            int dniExistente = 77777777; // Cliente ya cargado (Laura Pérez)

            // Act: llamamos al método que busca por DNI
            Cliente resultado = clienteDAL.BuscarPorDni(dniExistente);

            // Assert: verificamos que el resultado no sea nulo y que el DNI coincida
            Assert.IsNotNull(resultado, "No se encontró ningún cliente con el DNI especificado.");
            Assert.AreEqual(dniExistente, resultado.Dni);
        }
    }
}

