using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    abstract public class DAL_BaseDetalle
    {
		private int _cantidadDetalle;

		public int CantidadDetalle
		{
			get { return _cantidadDetalle; }
			set { _cantidadDetalle = value; }
		}
		private decimal _precioDetalle;

		public decimal PrecioDetalle
		{
			get { return _precioDetalle; }
			set { _precioDetalle = value; }
		}

		private DAL_Libro _unLibro;

		public DAL_Libro UnLibro
		{
			get { return _unLibro; }
			set { _unLibro = value; }
		}

	}
}
