using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using System.Data.SqlClient;
using Libreria.DAL;
using LibreriaUniversitaria.Datos; //  para acceder a ClienteRepository

namespace LibreriaUniversitaria.LogicaNegocio
{
    /// <summary>
    /// Clase de servicio que encapsula la lógica de negocio relacionada con los clientes.
    /// Se comunica con la capa de acceso a datos para obtener y manipular información.
    /// </summary>
    public static class ClienteService
    {
        /// <summary>
        /// Devuelve la lista completa de clientes registrados.
        /// </summary>
        public static List<Cliente> ObtenerClientes()
        {
            return ClienteRepository.ObtenerTodos();
        }

        /// <summary>
        /// Busca un cliente por su identificador único.
        /// </summary>
        public static Cliente BuscarClientePorId(int id)
        {
            return ClienteRepository.BuscarPorId(id);
        }

        /// <summary>
        /// Busca un cliente por tipo y número de documento.
        /// </summary>
        public static Cliente BuscarPorDocumento(string tipoDoc, string nroDoc)
        {
            return ClienteRepository.BuscarPorDocumento(tipoDoc, nroDoc);
        }

        /// <summary>
        /// Registra un nuevo cliente en el sistema.
        /// </summary>
        public static void RegistrarCliente(Cliente cliente)
        {
            ClienteRepository.Insertar(cliente);
        }

        /// <summary>
        /// Modifica los datos de un cliente existente.
        /// </summary>
        public static void ActualizarCliente(Cliente cliente)
        {
            ClienteRepository.Actualizar(cliente);
        }

        /// <summary>
        /// Elimina un cliente del sistema por su ID.
        /// </summary>
        public static void EliminarCliente(int id)
        {
            ClienteRepository.Eliminar(id);
        }
    }
}
