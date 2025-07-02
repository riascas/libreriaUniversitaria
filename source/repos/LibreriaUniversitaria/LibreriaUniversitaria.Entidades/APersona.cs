using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase abstracta base para representar una persona en el sistema.
    /// </summary>
    public abstract class APersona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int  Dni { get; set; }
        public string Email { get; set; }
        public Domicilio Domicilio { get; set; }

        // Constructor por defecto
        public APersona() { }

        // Constructor completo
        public APersona(int idPersona, string nombre, string apellido, int dni, string email, Domicilio domicilio)
        {
            IdPersona = idPersona;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
            Domicilio = domicilio;
        }
    }
}


