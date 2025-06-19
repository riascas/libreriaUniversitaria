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
        /// <summary>
        /// Validamos que el usuario y la clave no esten vacios para iniciar sesion.
        /// </summary>
        /// <returns></returns>
        public bool IniciarSesion()
        {
            
            return !string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Clave);
        }
    }
}
