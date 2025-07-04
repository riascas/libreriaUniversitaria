using System;

namespace LibreriaUniversitaria.Entidades
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public int IdEditorial { get; set; }

        public int IdCategoria { get; set; }    // FK a la tabla Categoria
        public string Categoria { get; set; }    // Nombre de la categoría

        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public bool Activo { get; set; }
    }
}
