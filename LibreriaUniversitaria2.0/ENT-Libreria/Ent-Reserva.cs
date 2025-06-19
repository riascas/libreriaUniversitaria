using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Reserva
    {
        private List<DetalleReserva> _detalleReservas;
        private DateTime _fechaReserva;
        private EstadoReserva _unEstadoReserva;

        public List<DetalleReserva> DetalleReservas
        {
            get { return _detalleReservas; }
            set { _detalleReservas = value; }
        }

        public DateTime FechaReserva
        {
            get { return _fechaReserva; }
            set { _fechaReserva = value; }
        }

        public EstadoReserva UnEstadoReserva
        {
            get { return _unEstadoReserva; }
            set { _unEstadoReserva = value; }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var detalle in DetalleReservas)
            {
                total += detalle.CalcularSubTotal();
            }

            return total;
        }

        public void CancelarReserva()
        {
            if (UnEstadoReserva.DescripcionEstadoReserva == "Reservado")
            {
                UnEstadoReserva.DescripcionEstadoReserva = "Cancelado";
            }
            else
            {
                throw new InvalidOperationException("La reserva no se puede cancelar porque ya está en un estado diferente.");
            }

        }
    }
}
