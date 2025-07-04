using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class DetalleOrdenCompra : BaseDetalle
    {
        private decimal _precioCosto;

        public decimal PrecioCosto
        {
            get { return _precioCosto; }
            set { _precioCosto = value; }
        }

        private decimal DetalleVenta;

        public decimal _detalleventa
        {
            get { return DetalleVenta; }
            set { DetalleVenta = value; }
        }


        public decimal CalcularSubTotal()
        {
            return Cantidad * PrecioCosto;

        }
    }
}
