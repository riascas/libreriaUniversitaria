using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_Libreria;
using ENT_Libreria;

namespace BLL_Libreria
{
    public class LocalidadService
    {
        private LocalidadDAO dao = new LocalidadDAO();

        public List<Localidad> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }
    }
}
