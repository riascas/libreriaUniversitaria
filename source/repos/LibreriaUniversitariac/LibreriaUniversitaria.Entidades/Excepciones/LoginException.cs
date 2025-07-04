using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades.Excepciones
{
    /// <summary>
    /// Excepción personalizada para errores en el inicio de sesión.
    /// </summary>
    public class LoginException : Exception
    {
        public LoginException() { }

        public LoginException(string mensaje) : base(mensaje) { }

        public LoginException(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}

