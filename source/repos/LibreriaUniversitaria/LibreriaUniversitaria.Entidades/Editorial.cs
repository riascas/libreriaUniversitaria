using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa una editorial responsable de la publicación de libros.
    /// </summary>
    public class Editorial
    {
        public int IdEditorial { get; set; }     // Identificador único de la editorial
        public string Nombre { get; set; }       // Nombre de la editorial
        public string Email { get; set; }        // Correo electrónico de contacto

        // Constructor por defecto
        public Editorial() { }

        // Constructor completo
        public Editorial(int idEditorial, string nombre, string email)
        {
            IdEditorial = idEditorial;
            Nombre = nombre;
            Email = email;
        }
    }
}
