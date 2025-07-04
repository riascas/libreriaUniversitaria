using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa una localidad dentro del sistema, asociada a un municipio.
    /// </summary>
    public class Localidad
    {
        public int IdLocalidad { get; set; }      // Identificador único de la localidad
        public string Nombre { get; set; }        // Nombre de la localidad
        public int IdMunicipio { get; set; }      // Clave foránea al municipio

        // Constructor por defecto
        public Localidad() { }

        // Constructor completo
        public Localidad(int idLocalidad, string nombre, int idMunicipio)
        {
            IdLocalidad = idLocalidad;
            Nombre = nombre;
            IdMunicipio = idMunicipio;
        }
    }
}
