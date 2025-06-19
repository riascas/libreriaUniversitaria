using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Localidad
    {
		private string _nombreLocalidad;

		public string NombreLocalidad
		{
			get { return _nombreLocalidad; }
			set { _nombreLocalidad = value; }
		}

		private DAL_Municipio _unMunicipio;

		public DAL_Municipio UnMunicipio
		{
			get { return _unMunicipio; }
			set { _unMunicipio = value; }
		}

	}
}
