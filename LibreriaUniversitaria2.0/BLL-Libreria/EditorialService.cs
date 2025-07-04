using DAT_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class EditorialService
    {
        private EditorialDAO editorialDAO = new EditorialDAO();
        public List<Editorial> ObtenerTodos()
        {
            return editorialDAO.ObtenerTodos();
        }

        public int Insertar(Editorial editorial)
        {
            return editorialDAO.Insertar(editorial);
        }
    }
}
