using DAT_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class CategoriaLibroService
    {
        private CategoriaLibroDAO categorialibroDAO = new CategoriaLibroDAO();
        public List<CategoriaLibro> ObtenerTodos()
        {
            return categorialibroDAO.ObtenerTodos();
        }
    }
}
