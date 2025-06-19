using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_MovimientoStock
    {
		private int _cantidadStock;

		public int CantidadStock
		{
			get { return _cantidadStock; }
			set { _cantidadStock = value; }
		}

		private DateTime _fechaStock;

		public DateTime FechaStock
		{
			get { return _fechaStock; }
			set { _fechaStock = value; }
		}

		
	}
}
