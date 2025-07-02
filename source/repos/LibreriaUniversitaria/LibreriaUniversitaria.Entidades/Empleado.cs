using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un empleado de la librería.
    /// Hereda de APersona e incluye datos adicionales para login y rol.
    /// </summary>
    public class Empleado : APersona
    {
        /// <summary>
        /// Identificador único del empleado (clave primaria en la BD).
        /// </summary>
        public int IdEmpleado { get; set; }

        /// <summary>
        /// Clave foránea al rol del empleado.
        /// </summary>
        public int IdRol { get; set; }

        /// <summary>
        /// Nombre de usuario del empleado (puede ser su DNI).
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Contraseña del empleado para el login.
        /// </summary>
        public string Clave { get; set; }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Empleado() { }

        /// <summary>
        /// Constructor completo para inicializar todos los campos del empleado.
        /// </summary>
        public Empleado(int idEmpleado, int idPersona, string nombre, string apellido, int dni, string email, Domicilio domicilio, int idRol, string usuario, string clave)
            : base(idPersona, nombre, apellido, dni, email, domicilio)
        {
            IdEmpleado = idEmpleado;
            IdRol = idRol;
            Usuario = usuario;
            Clave = clave;
        }
    }
}

