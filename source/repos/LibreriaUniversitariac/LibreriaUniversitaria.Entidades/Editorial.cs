using System;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa una editorial responsable de la publicación de libros.
    /// </summary>
    public class Editorial
    {
        public int IdEditorial { get; set; }    // Identificador único de la editorial
        public string Nombre { get; set; }    // Nombre de la editorial
        public string Email { get; set; }    // Correo electrónico de contacto

        public Editorial() { }

        public Editorial(int idEditorial, string nombre, string email)
        {
            IdEditorial = idEditorial;
            Nombre = nombre;
            Email = email;
        }
    }
}
