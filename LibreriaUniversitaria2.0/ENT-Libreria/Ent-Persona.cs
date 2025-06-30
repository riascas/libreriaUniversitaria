using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Persona
    {
        private int _idPersona;
        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _email;
        private Domicilio _unDomicilio;

        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }
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

        public Domicilio UnDomicilio
        {
            get { return _unDomicilio; }
            set { _unDomicilio = value; }
        }
    }
}
