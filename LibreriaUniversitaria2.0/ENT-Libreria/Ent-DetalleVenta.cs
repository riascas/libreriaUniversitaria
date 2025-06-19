using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class DetalleVenta : BaseDetalle
    {
        private decimal _precioVenta;

        public decimal PrecioVenta
        {
            get { return _precioVenta; }
            set { _precioVenta = value; }
        }
        /// <summary>
        /// Metodo que calcula el subtotal de un detalle de venta.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public decimal CalcularSubTotal()
        {
           
            return Cantidad * PrecioVenta;
        }
    }
}
