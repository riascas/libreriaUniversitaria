using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class RolEmpleado

    {
        private int _idRolEmpleado;
        private string _rol;

        public int IdRolEmpleado
        {
            get { return _idRolEmpleado; }
            set { _idRolEmpleado = value; }
        }


        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        
    }
}
