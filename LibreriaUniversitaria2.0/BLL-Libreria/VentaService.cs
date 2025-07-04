using DAT_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class VentaService
    {
        private VentaDAO ventaDAO = new VentaDAO();
        private DetalleVentaDAO detalleDAO = new DetalleVentaDAO();
        private MovimientoStockDAO stockDAO = new MovimientoStockDAO();

        public void RegistrarVenta(Venta venta)
        {
            int idVenta = ventaDAO.Insertar(venta);
            venta.IdVenta = idVenta;

            foreach (var detalle in venta.DetalleVentas)
            {
                detalle.UnaVenta = venta;
                int idDetalle = detalleDAO.Insertar(detalle);
                detalle.IdDetalleVenta = idDetalle;

                if (detalle.LibroReferencia == null)
                {
                    throw new Exception("Error: El libro de esta venta no fue asignado correctamente.");
                }

                var movimiento = new MovimientoStock
                {
                    FechaStock = DateTime.Now,
                    CantidadStock = -detalle.CantidadVenta,
                    UnLibro = detalle.LibroReferencia,
                    UnDetalleVenta = detalle
                };

                stockDAO.Insertar(movimiento);
            }
        }
    }
}
