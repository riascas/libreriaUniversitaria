using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaUniversitaria.Entidades
{
    public class Libro
    {
        public int Id { get; set; }             // Identificador del libro
        public string Titulo { get; set; }      // Título del libro
        public string Autor { get; set; }       // Autor
        public decimal Precio { get; set; }     // Precio de venta
        public int Stock { get; set; }          // Cantidad disponible en stock

        public int IdEditorial { get; set; }                 // Clave foránea
        public Editorial Editorial { get; set; }             // Navegación EF

        // Constructor vacío útil para evitar nulls
        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
        }
    }
}



