using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAT_Libreria;
using ENT_Libreria;


namespace BLL_Libreria
{
    public class EmpleadoService
    {
        private EmpleadoDAO empleadoDAO = new EmpleadoDAO();

        public Empleado Login(string usuario, string clave)
        {
            return empleadoDAO.BuscarPorUsuarioYClave(usuario, clave);
        }

        public List<Empleado> ObtenerTodos()
        {
            return empleadoDAO.ObtenerTodos();
        }

        public int AltaEmpleado(Empleado emp)
        {
            return empleadoDAO.AltaEmpleado(emp);
        }
    }

}
