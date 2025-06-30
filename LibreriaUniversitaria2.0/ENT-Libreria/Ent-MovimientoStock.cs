using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class MovimientoStock
    {
        private int _idStock;
        private int _cantidadStock;
        private DateTime _fechaStock;
        private DetalleOrdenCompra _unDetalleOrdenCompra;
        private Libro _unLibro;
        private DetalleVenta _unDetalleVenta;
        private DetalleReserva _unDetalleReserva;

        public int IdStock
        {
            get { return _idStock; }
            set { _idStock = value; }
        }
        public int CantidadStock
        {
            get { return _cantidadStock; }
            set { _cantidadStock = value; }
        }

        public DateTime FechaStock
        {
            get { return _fechaStock; }
            set { _fechaStock = value; }
        }

        public DetalleOrdenCompra UnDetalleOrdenCompra
        {
            get { return _unDetalleOrdenCompra; }
            set { _unDetalleOrdenCompra = value; }
        }

        public Libro UnLibro
        {
            get { return _unLibro; }
            set { _unLibro = value; }
        }

        public DetalleVenta UnDetalleVenta
        {
            get { return _unDetalleVenta; }
            set { _unDetalleVenta = value; }
        }

        public DetalleReserva UnDetalleReserva
        {
            get { return _unDetalleReserva; }
            set { _unDetalleReserva = value; }
        }
    }
}
