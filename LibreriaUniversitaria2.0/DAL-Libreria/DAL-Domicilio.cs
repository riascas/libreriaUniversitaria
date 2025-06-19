using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Domicilio
    {
		private string _calle;

		public string Calle
		{
			get { return _calle; }
			set { _calle = value; }
		}

		private int _altura;

		public int Altura
		{
			get { return _altura; }
			set { _altura = value; }
		}

		private DAL_Localidad _unaLocalidad;

		public DAL_Localidad UnaLocalidad
		{
			get { return _unaLocalidad; }
			set { _unaLocalidad = value; }
		}

	}
}
