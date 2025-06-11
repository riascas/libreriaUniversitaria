using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase abstracta que representa una persona en general
    public abstract class APersona
    {
        protected string _nombre;
        protected string _apellido;
        protected string _email;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        // Metodo comun que podria sobrescribirse
        public virtual string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
