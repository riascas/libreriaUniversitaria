using DAT_Libreria;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class EstadoLibroService
    {
        private EstadoLibroDAO estadolibroDAO = new EstadoLibroDAO();
        public List<EstadoLibro> ObtenerTodos()
        {
            return estadolibroDAO.ObtenerTodos();
        }
    }
}
