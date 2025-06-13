using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using System.Data.SqlClient;
using Libreria.DAL;
using LibreriaUniversitaria.Datos; 
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.LogicaNegocio
{
    /// <summary>
    /// Clase de lógica de negocio para operaciones relacionadas con clientes.
    /// </summary>
    public static class ClienteService
    {
        /// <summary>
        /// Devuelve todos los clientes registrados.
        /// </summary>
        public static List<Cliente> ObtenerTodos()
        {
            return ClienteRepository.ObtenerTodos();
        }

        /// <summary>
        /// Busca un cliente por número de documento (DNI).
        /// </summary>
        public static Cliente BuscarPorDocumento(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni) || dni.Length != 8)
                throw new ArgumentException("El número de documento debe tener 8 dígitos.");

            return ClienteRepository.BuscarPorDocumento(dni);
        }

        /// <summary>
        /// Registra un nuevo cliente si no existe otro con el mismo DNI.
        /// </summary>
        public static void Registrar(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException("El cliente no puede ser nulo.");

            cliente.Validar();

            var existente = ClienteRepository.BuscarPorDocumento(cliente.NumeroDocumento);
            if (existente != null)
                throw new ClienteExistenteException("Ya existe un cliente con el mismo documento.");

            ClienteRepository.Registrar(cliente);
        }
    }
}