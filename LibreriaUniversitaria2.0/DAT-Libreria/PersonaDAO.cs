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
    public class PersonaDAO
    {
        private Conexion conexion = new Conexion();

        public List<Persona> ObtenerTodos()
        {
            List<Persona> lista = new List<Persona>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Persona");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Persona
                {
                    IdPersona = Convert.ToInt32(fila["idPersona"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    DNI = fila["DNI"].ToString(),
                    Email = fila["Email"].ToString()
                });
            }
            return lista;
        }
    }
}
