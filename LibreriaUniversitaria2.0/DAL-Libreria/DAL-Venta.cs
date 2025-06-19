using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Venta
    {
		private DateTime _fechaVenta;

		public DateTime FechaVenta
		{
			get { return _fechaVenta; }
			set { _fechaVenta = value; }
		}

		private DAL_Empleado _unEmpleado;

		public DAL_Empleado UnEmpleado
		{
			get { return _unEmpleado; }
			set { _unEmpleado = value; }
		}

		private DAL_Cliente _unCliente;

		public DAL_Cliente UnCliente
		{
			get { return _unCliente; }
			set { _unCliente = value; }
		}

	}
}
