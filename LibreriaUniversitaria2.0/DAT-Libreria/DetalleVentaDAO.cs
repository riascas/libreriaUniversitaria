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

        public int Insertar(DetalleVenta detalle)
        {
            string query = $"INSERT INTO DetalleVenta (CantidadVenta, PrecioVenta, FK_Venta) VALUES ({detalle.CantidadVenta}, {detalle.PrecioVenta}, {detalle.UnaVenta.IdVenta})";
            conexion.EscribirPorComando(query);
            DataTable tablaID = conexion.LeerPorComando("SELECT IDENT_CURRENT('DetalleVenta') AS UltimoID");
            return Convert.ToInt32(tablaID.Rows[0]["UltimoID"]);
        }
    }
}
