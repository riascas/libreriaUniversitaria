using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class ClienteBLL
    {
        private readonly ClienteDAL clienteDAL;

        public ClienteBLL()
        {
            clienteDAL = new ClienteDAL();
        }

        // Agrega un nuevo cliente
        public void Insertar(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException("El cliente no puede ser nulo.");

            clienteDAL.Insertar(cliente);
        }

        // Devuelve todos los clientes
        public List<Cliente> ObtenerTodos()
        {
            return clienteDAL.ObtenerTodos();
        }

        // Busca un cliente por su DNI
        public Cliente BuscarPorDni(int dni)
        {
            if (dni <= 0)
                throw new ArgumentException("El DNI debe ser un número válido.");

            return clienteDAL.BuscarPorDni(dni);
        }

        // Actualiza un cliente (sus datos personales)
        public void Actualizar(Cliente cliente)
        {
            if (cliente == null)
                throw new ArgumentNullException("El cliente no puede ser nulo.");

            clienteDAL.Actualizar(cliente);
        }

        // Elimina un cliente usando su ID de Cliente y de Persona
        public void Eliminar(int idCliente, int idPersona)
        {
            if (idCliente <= 0 || idPersona <= 0)
                throw new ArgumentException("Los IDs deben ser válidos y mayores que cero.");

            clienteDAL.Eliminar(idCliente, idPersona);
        }
    }
}
