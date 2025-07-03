using System;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un empleado de la librería.
    /// Hereda de APersona e incluye datos adicionales para login y rol.
    /// </summary>
    public class Empleado : APersona
    {
        public int IdEmpleado { get; set; }
        public int IdRol { get; set; }
        public string Usuario { get; set; }  // Este campo podés dejarlo vacío si no se usa.
        public string Clave { get; set; }

        // ✅ Nueva propiedad para mostrar el nombre del rol (Administrador, Vendedor, etc.)
        public string NombreRol { get; set; }

        public Empleado() { }

        public Empleado(int idEmpleado, int idPersona, string nombre, string apellido, int dni, string email, Domicilio domicilio, int idRol, string usuario, string clave, string nombreRol)
            : base(idPersona, nombre, apellido, dni, email, domicilio)
        {
            IdEmpleado = idEmpleado;
            IdRol = idRol;
            Usuario = usuario;
            Clave = clave;
            NombreRol = nombreRol;
        }
    }
}
