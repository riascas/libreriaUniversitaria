using DAT_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class LibroService
    {
        private LibroDAO libroDAO = new LibroDAO();
        public List<Libro> ObtenerTodos()
        {
            return libroDAO.ObtenerTodos();
        }

        public Libro BuscarPorId(int id)
        {
            // Aquí deberías tener una lógica que consulte la base de datos o lista de libros
            // y devuelva el objeto Libro con ese ID
            // Ejemplo simple:
            return ObtenerTodos().FirstOrDefault(l => l.IdLibro == id);
        }

    }
}
