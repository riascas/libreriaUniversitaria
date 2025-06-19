using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    abstract public class DAL_Persona
    {
		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { _email = value; }
		}

		private string _dni;

		public string DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private DAL_Domicilio _unDomicilio;

		public DAL_Domicilio UnDomicilio
		{
			get { return _unDomicilio; }
			set { _unDomicilio = value; }
		}

	}
}
