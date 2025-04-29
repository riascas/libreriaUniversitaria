using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;

namespace Persistencia
{
    using LibreriaUniversitaria.Entidades;

    // Repositorio simulado para manejar operaciones con libros
    public class LibroRepository
    {
        // Lista simulada como "base de datos en memoria"
        private List<Libro> libros = new List<Libro>();

        // Agrega un libro a la lista
        public void Agregar(Libro libro) => libros.Add(libro);

        // Devuelve todos los libros registrados
        public List<Libro> ObtenerTodos() => libros;
    }
}