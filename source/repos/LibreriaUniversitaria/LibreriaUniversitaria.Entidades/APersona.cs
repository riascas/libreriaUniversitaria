using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa a una persona dentro del sistema.
    /// </summary>
    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }

        // Relación uno a uno con Domicilio
        public Domicilio Domicilio { get; set; }

        // Constructor por defecto
        public Persona() { }

        // Constructor completo
        public Persona(int idPersona, string nombre, string apellido, string dni, string email, Domicilio domicilio)
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

