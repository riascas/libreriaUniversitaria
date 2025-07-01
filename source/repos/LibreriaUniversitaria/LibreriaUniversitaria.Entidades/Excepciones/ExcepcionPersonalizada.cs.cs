using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LibreriaUniversitaria.Entidades.Excepciones
{
    /// <summary>
    /// Clase de excepción personalizada de ejemplo.
    /// Sirve como base para futuras excepciones específicas del sistema.
    /// </summary>
    public class ExcepcionPersonalizada : Exception
    {
        public string Mensaje { get; set; }

        public ExcepcionPersonalizada(string mensaje)
        {
            Mensaje = mensaje;
        }

        public override string ToString()
        {
            return $"Error personalizado: {Mensaje}";
        }
    }
}
