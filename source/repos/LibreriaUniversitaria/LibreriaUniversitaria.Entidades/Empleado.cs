using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un empleado de la librería.
    /// </summary>
    public class Empleado : Persona
    {
        // Clave foránea al Rol del empleado
        public int IdRol { get; set; }

        // Nombre de usuario para login
        public string Usuario { get; set; }

        // Contraseña para login
        public string Clave { get; set; }

        // Constructor por defecto
        public Empleado() { }

        // Constructor completo
        public Empleado(int idPersona, string nombre, string apellido, string dni, string email, Domicilio domicilio, int idRol, string usuario, string clave)
            : base(idPersona, nombre, apellido, dni, email, domicilio)
        {
            IdRol = idRol;
            Usuario = usuario;
            Clave = clave;
        }
    }
}


