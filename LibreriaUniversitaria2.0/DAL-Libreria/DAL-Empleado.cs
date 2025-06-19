using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Empleado : DAL_Persona
    {
		private string _usuario;

		public string Usuario
		{
			get { return _usuario; }
			set { _usuario = value; }
		}

		private string _clave;

		public string Clave
		{
			get { return _clave; }
			set { _clave = value; }
		}

		private DAL_RolEmpleado _unRol;

		public DAL_RolEmpleado UnRol
		{
			get { return _unRol; }
			set { _unRol = value; }
		}

	}
}
