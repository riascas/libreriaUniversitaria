using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    using Entidades;

    public class LibroRepository
    {
        private List<Libro> libros = new List<Libro>();

        public void Agregar(Libro libro) => libros.Add(libro);
        public List<Libro> ObtenerTodos() => libros;
    }
}