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

        public decimal CalcularSubTotal()
        {
            return Cantidad * PrecioVenta;
        }
    }
}
