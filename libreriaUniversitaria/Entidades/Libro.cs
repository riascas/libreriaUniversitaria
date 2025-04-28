using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades

{
    public class Libro
    {
        public int Id { get; set; } // Identificador
        public string Titulo { get; set; } // Título del libro
        public string Autor { get; set; } // Autor
        public decimal Precio { get; set; } // Precio
        public int Stock { get; set; } // Stock disponible

        // Constructor vacío
        public Libro()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
        }
    }
}


