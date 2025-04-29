using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaUniversitaria.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }                          // Identificador único del cliente
        public string Dni { get; set; }                      // Documento de identidad
        public string Nombre { get; set; }                   // Nombre completo
        public string Email { get; set; }                    // Correo electrónico
        public DateTime FechaNacimiento { get; set; }        // Fecha de nacimiento
        public string Direccion { get; set; }                // Dirección (sin localidad)

        public bool EsEstudiante { get; set; }               // ¿Tiene derecho a descuento?

        public int IdLocalidad { get; set; }                 // Clave foránea
        public Localidad Localidad { get; set; }             // Propiedad de navegación EF     


        // Descuento no se modela como una entidad ahora, ya que se aplica automáticamente si EsEstudiante == true.


        // Constructor vacío útil para inicializaciones
        public Cliente()
        {
            Dni = string.Empty;
            Nombre = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            Localidad = new Localidad(); // Evita el warning:Se evita el warning CS8618 inicializando las propiedades no-null en el constructor o permitiendo que sean null. Esto garantiza que el objeto esté en un estado válido al crearse y evita errores en tiempo de ejecución por valores null.
        }
    }
}
