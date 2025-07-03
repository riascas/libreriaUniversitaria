using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades.Excepciones
{
    /// <summary>
    /// Se lanza cuando el login del empleado falla por credenciales incorrectas.
    /// </summary>
    public class ExcepcionLoginInvalido : Exception
    {
        public ExcepcionLoginInvalido()
            : base("Usuario o contraseña incorrectos.") { }

        public ExcepcionLoginInvalido(string mensaje)
            : base(mensaje) { }

        public ExcepcionLoginInvalido(string mensaje, Exception innerException)
            : base(mensaje, innerException) { }
    }
}

