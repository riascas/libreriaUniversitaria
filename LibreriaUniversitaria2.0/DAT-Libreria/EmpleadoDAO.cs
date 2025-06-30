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
    public class EmpleadoDAO
    {
        private Conexion conexion = new Conexion();

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> lista = new List<Empleado>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Empleado");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Empleado
                {
                    IdEmpleado = Convert.ToInt32(fila["idEmpleado"]),
                    Usuario = fila["Usuario"].ToString(),
                    Clave = fila["Clave"].ToString(),
                    UnRol = new RolEmpleado
                    {
                        IdRolEmpleado = Convert.ToInt32(fila["idRolEmpleado"]),
                        Rol = fila["Rol"].ToString()
                    },
                    UnaPersona = new Persona
                    {
                        IdPersona = Convert.ToInt32(fila["idPersona"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        DNI = fila["DNI"].ToString(),
                        Email = fila["Email"].ToString()
                    }
                });
            }
            return lista;
        }
    }
}
