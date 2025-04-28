using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    using Entidades;

    public class ClienteRepository
    {
        private List<Cliente> clientes = new List<Cliente>();

        public void Agregar(Cliente cliente) => clientes.Add(cliente);
        public List<Cliente> ObtenerTodos() => clientes;
    }
}
