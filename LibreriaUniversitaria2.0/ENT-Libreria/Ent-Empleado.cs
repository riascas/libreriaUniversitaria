using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Empleado : Persona
    {
        private string _clave;
        private RolEmpleado _unRol;
        private string _usuario;
        private int _idEmpleado;
        private Persona _unaPersona;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public RolEmpleado UnRol
        {
            get { return _unRol; }
            set { _unRol = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }
        
        public Persona UnaPersona
        {
            get { return _unaPersona; }
            set { _unaPersona = value; }
        }
        
    }
}
