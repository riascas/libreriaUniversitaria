using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades.Excepciones
{
    /// <summary>
    /// Excepcion personalizada que se lanza cuando una entidad tiene datos invalidos.
    /// </summary>
    public class EntidadInvalidaException : Exception
    {
        public EntidadInvalidaException() : base("La entidad contiene datos inválidos.") { }

        public EntidadInvalidaException(string mensaje) : base(mensaje) { }

        public EntidadInvalidaException(string mensaje, Exception inner) : base(mensaje, inner) { }
    }
}
