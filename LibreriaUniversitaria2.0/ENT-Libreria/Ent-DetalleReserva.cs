using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class DetalleReserva : BaseDetalle
    {
        private decimal _precioEstimado;

        public decimal PrecioEstimado
        {
            get { return _precioEstimado; }
            set { _precioEstimado = value; }
        }

        public decimal CalcularSubTotal()
        {
            return Cantidad * PrecioEstimado;
        }
    }
}
