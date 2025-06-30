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
    public class RolEmpleadoDAO
    {
        private Conexion conexion = new Conexion();

        public List<RolEmpleado> ObtenerTodos()
        {
            List<RolEmpleado> lista = new List<RolEmpleado>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM RolEmpleado");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new RolEmpleado
                {
                    IdRolEmpleado = Convert.ToInt32(fila["idRolEmpleado"]),
                    Rol = fila["Rol"].ToString()
                });
            }
            return lista;
        }
    }
}
