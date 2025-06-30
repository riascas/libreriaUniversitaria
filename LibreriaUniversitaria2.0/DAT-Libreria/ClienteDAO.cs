using DAL;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Libreria
{
    public class ClienteDAO
    {
        private Conexion conexion = new Conexion();

        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Cliente");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Cliente
                {
                    IdCliente = Convert.ToInt32(fila["idCliente"]),
                    EsEstudiante = Convert.ToBoolean(fila["EsEstudiante"]),
                    UnaPersona = new Persona
                    {
                        IdPersona = Convert.ToInt32(fila["idPersona"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        DNI = fila["DNI"].ToString(),
                        Email = fila["Email"].ToString(),
                        
                    }
                });
            }
            return lista;
        }

        public int Insertar(Cliente cliente)
        {
            string query = $"INSERT INTO Cliente (EsEstudiante, UnaPersona) VALUES ('{(cliente.EsEstudiante ? 1 : 0)}', {cliente.UnaPersona})";
            return conexion.EscribirPorComando(query);
        }
    }
}
