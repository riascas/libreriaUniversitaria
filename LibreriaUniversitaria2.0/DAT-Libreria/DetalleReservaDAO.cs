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
    public class DetalleReservaDAO
    {
        private Conexion conexion = new Conexion();

        public List<DetalleReserva> ObtenerTodos()
        {
            List<DetalleReserva> lista = new List<DetalleReserva>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM DetalleReserva");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new DetalleReserva
                {
                    IdDetalleReserva = Convert.ToInt32(fila["idDetalleReserva"]),
                    CantidadReserva = Convert.ToInt32(fila["CantidadReserva"]),
                    PrecioReserva = Convert.ToDecimal(fila["PrecioReserva"]),
                    UnaReserva = new Reserva
                    {
                        IdReserva = Convert.ToInt32(fila["idReserva"])
                    }
                });
            }
            return lista;
        }

        public int Insertar(DetalleReserva detalle)
        {
            string query = $"INSERT INTO DetalleReserva (CantidadReserva, PrecioReserva, idReserva) VALUES ({detalle.CantidadReserva}, {detalle.PrecioReserva}, {detalle.UnaReserva})";
            return conexion.EscribirPorComando(query);
        }
    }
}
