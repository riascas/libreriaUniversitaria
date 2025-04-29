using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Editorial
    {
        public int Id { get; set; }             // Identificador único de la editorial
        public string Nombre { get; set; }      // Nombre de la editorial
        public string Direccion { get; set; }   // Dirección de la editorial
        public string Telefono { get; set; }    // Teléfono de contacto
        public string Email { get; set; }       // Correo de contacto

        public Editorial()
        {
            Nombre = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            Email = string.Empty;
        }
    }
}
