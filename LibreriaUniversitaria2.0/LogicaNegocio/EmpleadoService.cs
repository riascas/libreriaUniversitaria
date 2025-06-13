using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.Datos;

namespace LibreriaUniversitaria.LogicaNegocio
{
    /// <summary>
    /// Clase de lógica de negocio para manejar operaciones con empleados (usuarios del sistema).
    /// </summary>
    public static class EmpleadoService
    {
        /// <summary>
        /// Devuelve todos los empleados registrados en el sistema.
        /// </summary>
        public static List<Empleado> ObtenerTodos()
        {
            return EmpleadoRepository.ObtenerTodos();
        }

        /// <summary>
        /// Busca un empleado por número de documento y clave (para login).
        /// </summary>
        /// <param name="documento">Número de documento (DNI) del empleado.</param>
        /// <param name="clave">Contraseña del empleado.</param>
        /// <returns>Empleado encontrado o null si no existe.</returns>
        public static Empleado BuscarPorDocumentoYClave(string documento, string clave)
        {
            if (string.IsNullOrWhiteSpace(documento) || string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("El documento y la clave son obligatorios.");

            return EmpleadoRepository.ObtenerPorDocumentoYClave(documento, clave);
        }

        /// <summary>
        /// Devuelve una lista de empleados filtrados por nombre de rol.
        /// </summary>
        /// <param name="rol">Nombre del rol (ej: "Vendedor", "Administrador")</param>
        public static List<Empleado> ObtenerPorRol(string rol)
        {
            return EmpleadoRepository.ObtenerPorRol(rol);
        }
    }
}

