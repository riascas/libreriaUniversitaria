using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_OrdenCompra
    {
		private DateTime _fechaCompra;

		public DateTime FechaCompra
		{
			get { return _fechaCompra; }
			set { _fechaCompra = value; }
		}

		private decimal _totalCompra;

		public decimal TotalCompra
		{
			get { return _totalCompra; }
			set { _totalCompra = value; }
		}

		private string _estadoCompra;

		public string EstadoCompra
		{
			get { return _estadoCompra; }
			set { _estadoCompra = value; }
		}

		private DAL_Editorial _unaEditorial;

		public DAL_Editorial UnaEditorial
		{
			get { return _unaEditorial; }
			set { _unaEditorial = value; }
		}

		private DAL_Empleado _unEmpleado;

		public DAL_Empleado UnEmpleado
		{
			get { return _unEmpleado; }
			set { _unEmpleado = value; }
		}

	}
}
