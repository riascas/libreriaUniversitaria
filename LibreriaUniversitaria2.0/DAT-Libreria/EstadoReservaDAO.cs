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
    public class EstadoReservaDAO
    {
        private Conexion conexion = new Conexion();

        public List<EstadoReserva> ObtenerTodos()
        {
            List<EstadoReserva> lista = new List<EstadoReserva>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM EstadoReserva");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new EstadoReserva
                {
                    IdEstadoReserva = Convert.ToInt32(fila["idEstadoReserva"]),
                    DescripcionEstadoReserva = fila["DescripcionEstadoReserva"].ToString()
                });
            }
            return lista;
        }
    }
}
