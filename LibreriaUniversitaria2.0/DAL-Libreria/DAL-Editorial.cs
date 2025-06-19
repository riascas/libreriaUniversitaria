using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Editorial
    {
		private string _nombreEditorial;

		public string NombreEditorial
		{
			get { return _nombreEditorial; }
			set { _nombreEditorial = value; }
		}

		private string _cuitEditorial;

		public string CuitEditorial
		{
			get { return _cuitEditorial; }
			set { _cuitEditorial = value; }
		}

		private string _contactoEditorial;

		public string ContactoEditorial
		{
			get { return _contactoEditorial; }
			set { _contactoEditorial = value; }
		}

	}
}
