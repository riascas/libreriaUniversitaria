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
        /// <summary>
        /// Metodo que calcula el subtotal de un detalle de orden de compra.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public decimal CalcularSubTotal()
        {
           
            return Cantidad * PrecioCosto;
        }
    }
}
