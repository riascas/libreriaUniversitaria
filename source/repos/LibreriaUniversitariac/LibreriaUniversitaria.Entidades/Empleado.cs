using System;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un empleado del sistema, hereda de Persona.
    /// </summary>
    public class Empleado : APersona
    {
        public int IdEmpleado { get; set; }

        /// <summary>
        /// (Antigua) Contraseña en texto plano. Solo hasta migrar todo a hash.
        /// </summary>
        public string Clave { get; set; }

        /// <summary>
        /// Hash seguro de la contraseña (BCrypt).
        /// </summary>
        public string ClaveHash { get; set; }

        
        public string Rol { get; set; }
       

        public Empleado() { }

        public Empleado(int idPersona, string nombre, string apellido, int dni, string email,
                        Domicilio domicilio, int idEmpleado, string rol)
            : base(idPersona, nombre, apellido, dni, email, domicilio)
        {
            IdEmpleado = idEmpleado;
            Rol = rol;
        }
    }
}
