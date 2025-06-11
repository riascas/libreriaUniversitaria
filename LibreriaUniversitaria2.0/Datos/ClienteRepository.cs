using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.Datos
{
    // Clase que simula una base de datos para la entidad Cliente
    public static class ClienteRepository
    {
        // Lista estatica que actua como base de datos
        private static List<Cliente> _clientes = new List<Cliente>();

        // Metodo para obtener todos los clientes
        public static List<Cliente> ObtenerTodos()
        {
            return _clientes;
        }

        // Metodo para buscar cliente por tipo y numero de documento
        public static Cliente BuscarPorDocumento(string tipo, string numero)
        {
            return _clientes.FirstOrDefault(c =>
                c.TipoDocumento.ToLower() == tipo.ToLower() &&
                c.NumeroDocumento == numero);
        }

        // Metodo para guardar un nuevo cliente
        public static void Guardar(Cliente cliente)
        {
            _clientes.Add(cliente);
        }

        // Metodo para actualizar un cliente existente
        public static void Actualizar(Cliente cliente)
        {
            var existente = BuscarPorDocumento(cliente.TipoDocumento, cliente.NumeroDocumento);
            if (existente != null)
            {
                existente.Nombre = cliente.Nombre;
                existente.Apellido = cliente.Apellido;
                existente.Email = cliente.Email;
                existente.EsEstudiante = cliente.EsEstudiante;
                existente.Domicilio = cliente.Domicilio;
                existente.Localidad = cliente.Localidad;
            }
        }

        // Metodo para eliminar un cliente por documento
        public static void Eliminar(string tipo, string numero)
        {
            var cliente = BuscarPorDocumento(tipo, numero);
            if (cliente != null)
            {
                _clientes.Remove(cliente);
            }
        }
    }
}

