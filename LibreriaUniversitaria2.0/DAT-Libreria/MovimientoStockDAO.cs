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

        public void Insertar(MovimientoStock movimiento)
        {
            string query = $"INSERT INTO MovimientoStock (FechaStock, CantidadStock, FK_Libro, FK_DetalleVenta) VALUES ('{movimiento.FechaStock:yyyy-MM-dd HH:mm:ss}', {movimiento.CantidadStock}, {movimiento.UnLibro.IdLibro}, {movimiento.UnDetalleVenta.IdDetalleVenta})";
            conexion.EscribirPorComando(query);
        }
    }
}
