using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Cliente : DAL_Persona
    {
		private bool _esEstudiante;

		public bool EsEstudiante
		{
			get { return _esEstudiante; }
			set { _esEstudiante = value; }
		}

	}
}
