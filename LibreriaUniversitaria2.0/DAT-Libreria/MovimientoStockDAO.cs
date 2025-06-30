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
    public class MovimientoStockDAO
    {
        private Conexion conexion = new Conexion();

        public List<MovimientoStock> ObtenerTodos()
        {
            List<MovimientoStock> lista = new List<MovimientoStock>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM MovimientoStock");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new MovimientoStock
                {
                    IdStock = Convert.ToInt32(fila["idStock"]),
                    FechaStock = Convert.ToDateTime(fila["FechaStock"]),
                    CantidadStock = Convert.ToInt32(fila["CantidadStock"]),
                    UnDetalleOrdenCompra = new DetalleOrdenCompra
                    {
                        IdDetalleCompra = Convert.ToInt32(fila["idDetalleOrdenCompra"])
                    },
                    UnLibro = new Libro
                    {
                        IdLibro = Convert.ToInt32(fila["idLibro"])
                    },
                    UnDetalleVenta = new DetalleVenta
                    {
                        IdDetalleVenta = Convert.ToInt32(fila["idDetalleVenta"])
                    },
                    UnDetalleReserva = new DetalleReserva
                    {
                        IdDetalleReserva = Convert.ToInt32(fila["idDetalleReserva"])
                    }
                });
            }
            return lista;
        }
    }
}
