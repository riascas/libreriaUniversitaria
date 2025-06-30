using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class DetalleVenta : BaseDetalle
    {
        private int _idDetalleVenta;
        private int _cantidadVenta;
        private decimal _precioVenta;
        private Venta _unaVenta;

        public int IdDetalleVenta
        {
            get { return _idDetalleVenta; }
            set { _idDetalleVenta = value; }
        }

        public int CantidadVenta
        {
            get { return _cantidadVenta; }
            set { _cantidadVenta = value; }
        }

        public Venta UnaVenta
        {
            get { return _unaVenta; }
            set { _unaVenta = value; }
        }
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
