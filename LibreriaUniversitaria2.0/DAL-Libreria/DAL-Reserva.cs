using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Reserva
    {
		private DateTime _fechaReserva;

		public DateTime FechaReserva
		{
			get { return _fechaReserva; }
			set { _fechaReserva = value; }
		}

		private DateTime _fechaRetiro;

		public DateTime FechaRetiro
		{
			get { return _fechaRetiro; }
			set { _fechaRetiro = value; }
		}


		private DAL_EstadoReserva _unEstadoReserva;

		public DAL_EstadoReserva UnEstadoReserva
		{
			get { return _unEstadoReserva; }
			set { _unEstadoReserva = value; }
		}

		private DAL_Cliente _unCliente;

		public DAL_Cliente UnCliente
		{
			get { return _unCliente; }
			set { _unCliente = value; }
		}

		private DAL_Empleado _unEmpleado;

		public DAL_Empleado UnEmpleado
		{
			get { return _unEmpleado; }
			set { _unEmpleado = value; }
		}

	}
}
