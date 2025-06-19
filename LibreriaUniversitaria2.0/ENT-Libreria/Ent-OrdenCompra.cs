using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class OrdenCompra
    {
        private DateTime _fechaCompra;
        private Editorial _unaEditorial;

        public DateTime FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }

        public Editorial UnaEditorial
        {
            get { return _unaEditorial; }
            set { _unaEditorial = value; }
        }
        /* me falta  hacer este metodo
        private decimal DetalleVenta;
        
        public decimal detalleventa
        {
            get { return DetalleVenta; }
            set { DetalleVenta = value; }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var detalle in DetalleVenta)
            {
                total += detalle.CalcularSubTotal();
            }

            return total;
        }
        */
    }
}
