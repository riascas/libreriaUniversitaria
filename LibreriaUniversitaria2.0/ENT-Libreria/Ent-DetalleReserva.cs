using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class DetalleReserva : BaseDetalle
    {
        private int _idDetalleReserva;
        private int _cantidadReserva;
        private decimal _precioReserva;
        private Reserva _unaReserva;

        public decimal PrecioReserva
        {
            get { return _precioReserva; }
            set { _precioReserva = value; }
        }
        
        public int IdDetalleReserva
        {
            get { return _idDetalleReserva; }
            set { _idDetalleReserva = value; }
        }
        public int CantidadReserva
        {
            get { return _cantidadReserva; }
            set { _cantidadReserva = value; }
        }

        public Reserva UnaReserva
        {
            get { return _unaReserva; }
            set { _unaReserva = value; }
        }

        public decimal CalcularSubTotal()
        {
            return CantidadReserva * PrecioReserva;
        }
    }
}
