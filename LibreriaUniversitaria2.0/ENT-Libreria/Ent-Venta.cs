using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Venta
    {
        private List<DetalleVenta> _detalleVentas;
        private DateTime _fechaVenta;

        public List<DetalleVenta> DetalleVentas
        {
            get { return _detalleVentas; }
            set { _detalleVentas = value; }
        }

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }
        public float AplicarDescuento()
        {
            decimal total = CalcularTotal();

            if (total > 1000)
                return 0.10f; // 10% de descuento

            return 0; // Sin descuento
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var detalle in DetalleVentas)
            {
                total += detalle.CalcularSubTotal();
            }

            return total;
        }

    }
 }
