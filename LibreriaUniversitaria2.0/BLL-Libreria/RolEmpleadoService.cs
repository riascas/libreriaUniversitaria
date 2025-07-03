using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_Libreria;
using ENT_Libreria;

namespace BLL_Libreria
{
    public class RolEmpleadoService
    {
        private RolEmpleadoDAO dao = new RolEmpleadoDAO();

        public List<RolEmpleado> ObtenerTodos()
        {
            return dao.ObtenerTodos();
        }
    }
}
