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
    public class EstadoLibroDAO
    {
        private Conexion conexion = new Conexion();

        public List<EstadoLibro> ObtenerTodos()
        {
            List<EstadoLibro> lista = new List<EstadoLibro>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM EstadoLibro");

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new EstadoLibro
                    {
                        IdEstadoLibro = Convert.ToInt32(fila["idEstadoLibro"]),
                        DescripcionEstadoLibro = fila["DescripcionEstadoLibro"].ToString()
                    });
                }
            }

            return lista;
        }

        public int InsertarEstado(EstadoLibro estado)
        {
            string query = $"INSERT INTO EstadoLibro (DescripcionEstadoLibro) VALUES ('{estado.DescripcionEstadoLibro}')";
            return conexion.EscribirPorComando(query);
        }
    }
}
