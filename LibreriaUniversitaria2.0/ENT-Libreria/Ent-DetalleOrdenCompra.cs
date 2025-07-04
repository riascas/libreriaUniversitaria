using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class DetalleOrdenCompra 
    {
        private int _idDetalleCompra;
        private int _cantidadCompra;
        private decimal _precioCosto;
        private OrdenCompra _unaOrdendeCompra;

        public int IdDetalleCompra
        {
            get { return _idDetalleCompra; }
            set { _idDetalleCompra = value; }
        }

        public OrdenCompra UnaOrdendeCompra
        {
            get { return _unaOrdendeCompra; }
            set { _unaOrdendeCompra = value; }
        }
        public decimal PrecioCosto
        {
            get { return _precioCosto; }
            set { _precioCosto = value; }
        }

        public int CantidadCompra
        {
            get { return _cantidadCompra; }
            set { _cantidadCompra = value; }
        }
    }
}
