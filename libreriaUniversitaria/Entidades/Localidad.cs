using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{ //Esto te permite cargar previamente las localidades en la base de datos y asociarlas al cliente mediante un IdLocalidad.
    public class Localidad
    {
        public int Id { get; set; }              // ID de la localidad
        public string Nombre { get; set; }       // Nombre de la ciudad/localidad
        public string Provincia { get; set; }    // Provincia a la que pertenece

        public Localidad()
        {
            Nombre = string.Empty;
            Provincia = string.Empty;
        }
    }
}
