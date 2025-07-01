using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un domicilio dentro del sistema de librería.
    /// </summary>
    public class Domicilio
    {
        // Identificador único del domicilio
        public int IdDomicilio { get; set; }

        // Nombre de la calle
        public string Calle { get; set; }

        // Altura o número del domicilio
        public int Altura { get; set; }

        // Código postal
        public string CP { get; set; }

        // Clave foránea a la localidad
        public int IdLocalidad { get; set; }

        // Constructor por defecto
        public Domicilio() { }

        // Constructor completo
        public Domicilio(int idDomicilio, string calle, int altura, string cp, int idLocalidad)
        {
            IdDomicilio = idDomicilio;
            Calle = calle;
            Altura = altura;
            CP = cp;
            IdLocalidad = idLocalidad;
        }
    }
}

