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
    public class DetalleVentaDAO
    {
        private Conexion conexion = new Conexion();

        public List<DetalleVenta> ObtenerTodos()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM DetalleVenta");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new DetalleVenta
                {
                    IdDetalleVenta = Convert.ToInt32(fila["idDetalleVenta"]),
                    CantidadVenta = Convert.ToInt32(fila["CantidadVenta"]),
                    PrecioVenta = Convert.ToDecimal(fila["PrecioVenta"]),
                    UnaVenta = new Venta
                    {
                        IdVenta = Convert.ToInt32(fila["idVenta"])
                    }
                });
            }
            return lista;
        }

        public int Insertar(DetalleVenta detalle)
        {
            string query = $"INSERT INTO DetalleVenta (CantidadVenta, PrecioVenta, idVenta) VALUES ({detalle.CantidadVenta}, {detalle.PrecioVenta}, {detalle.UnaVenta})";
            return conexion.EscribirPorComando(query);
        }
    }
}
