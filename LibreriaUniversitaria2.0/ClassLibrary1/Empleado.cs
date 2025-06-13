using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa a un empleado del sistema (Administrador, Vendedor, etc.).
    /// </summary>
    public class Empleado
    {
        /// <summary>
        /// Identificador único del empleado.
        /// </summary>
        public int IdEmpleado { get; set; }

        /// <summary>
        /// Nombre del empleado.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Apellido del empleado.
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Número de documento (DNI). Se usa como "usuario" en el login.
        /// </summary>
        public string Documento { get; set; }

        /// <summary>
        /// Clave de acceso al sistema (contraseña).
        /// </summary>
        public string Clave { get; set; }

        /// <summary>
        /// Rol del empleado (Administrador, Vendedor, etc.).
        /// </summary>
        public Rol Rol { get; set; }

        /// <summary>
        /// Constructor sin parámetros.
        /// </summary>
        public Empleado() { }

        /// <summary>
        /// Constructor con parámetros.
        /// </summary>
        public Empleado(int id, string nombre, string apellido, string documento, string clave, Rol rol)
        {
            IdEmpleado = id;
            Nombre = nombre;
            Apellido = apellido;
            Documento = documento;
            Clave = clave;
            Rol = rol;
        }

        /// <summary>
        /// Devuelve el nombre completo del empleado.
        /// </summary>
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Rol?.Nombre}";
        }
    }
}

