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
    }
}
