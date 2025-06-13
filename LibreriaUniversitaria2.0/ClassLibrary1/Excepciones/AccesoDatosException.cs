using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades.Excepciones
{
    /// <summary>
    /// Excepción que se lanza cuando ocurre un error en la capa de acceso a datos.
    /// </summary>
    public class AccesoDatosException : Exception
    {
        public AccesoDatosException() : base() { }
        public AccesoDatosException(string message) : base(message) { }
        public AccesoDatosException(string message, Exception inner) : base(message, inner) { }
    }
}
