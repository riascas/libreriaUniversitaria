using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un libro dentro del sistema de librería.
    /// </summary>
    public class Libro
    {
        public int IdLibro { get; set; }             // Identificador único del libro
        public string Titulo { get; set; }           // Título del libro
        public string Autor { get; set; }            // Autor del libro
        public string ISBN { get; set; }             // ISBN del libro
        public int IdEditorial { get; set; }         // Clave foránea a la editorial
        public int Stock { get; set; }               // Cantidad de unidades disponibles
        public decimal Precio { get; set; }          // Precio unitario
        public bool Activo { get; set; }             // Indica si está activo para la venta

        public Editorial Editorial { get; set; }     // Propiedad de navegación

        public Libro() { } // Constructor por defecto

        // Constructor completo
        public Libro(int idLibro, string titulo, string autor, string isbn, int idEditorial, int stock, decimal precio, bool activo)
        {
            IdLibro = idLibro;
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            IdEditorial = idEditorial;
            Stock = stock;
            Precio = precio;
            Activo = activo;
        }
    }
}

