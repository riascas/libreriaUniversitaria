using DAT_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class ClienteService
    {
        private ClienteDAO clienteDAO = new ClienteDAO();

        public List<Cliente> ObtenerTodos()
        {
            return clienteDAO.ObtenerTodos();
        }

        public int Insertar(Cliente cliente)
        {
            return clienteDAO.Insertar(cliente);
        }
    }
}
