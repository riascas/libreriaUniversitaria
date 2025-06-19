using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_SistemaLibreria
    {
		private DAL_Cliente _listaClientes;

		public DAL_Cliente ListaClientes
		{
			get { return _listaClientes; }
			set { _listaClientes = value; }
		}

		private DAL_Libro _listaLibros;

		public DAL_Libro ListaLibros
		{
			get { return _listaLibros; }
			set { _listaLibros = value; }
		}

		private DAL_Reserva _listaReserva;

		public DAL_Reserva ListaReserva
		{
			get { return _listaReserva; }
			set { _listaReserva = value; }
		}

		private DAL_Empleado _listaEmpleados;

		public DAL_Empleado ListaEmpleados
		{
			get { return _listaEmpleados; }
			set { _listaEmpleados = value; }
		}

		private DAL_Venta _listaVentas;

		public DAL_Venta ListaVentas
		{
			get { return _listaVentas; }
			set { _listaVentas = value; }
		}

	}
}
