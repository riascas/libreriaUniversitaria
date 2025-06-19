using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Persona
    {
        private string _apellido;
        private string _dni;
        private string _email;
        private string _nombre;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
