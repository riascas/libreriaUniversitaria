using System;
using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Lógica de negocio para la entidad Cliente.
    /// </summary>
    public class ClienteBLL
    {
        private readonly ClienteDAL _dal = new ClienteDAL();

        /// <summary>
        /// Obtiene todos los clientes.
        /// </summary>
        public List<Cliente> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        /// <summary>
        /// Obtiene un cliente por su Id.
        /// </summary>
        public Cliente ObtenerPorId(int idCliente)
        {
            return _dal.ObtenerPorId(idCliente);
        }

        /// <summary>
        /// Busca un cliente por DNI.
        /// </summary>
        public Cliente ObtenerPorDNI(int dni)
        {
            return _dal.ObtenerPorDNI(dni);
        }

        /// <summary>
        /// Crea un nuevo cliente.
        /// </summary>
        public void Alta(Cliente c)
        {
            if (c == null) throw new ArgumentNullException(nameof(c));
            _dal.Insertar(c);
        }

        /// <summary>
        /// Modifica un cliente existente.
        /// </summary>
        public void Modificar(Cliente c)
        {
            if (c == null) throw new ArgumentNullException(nameof(c));
            _dal.Actualizar(c);
        }

        /// <summary>
        /// Elimina un cliente.
        /// </summary>
        public void Eliminar(int idCliente, int idPersona)
        {
            _dal.Eliminar(idCliente, idPersona);
        }
    }
}
