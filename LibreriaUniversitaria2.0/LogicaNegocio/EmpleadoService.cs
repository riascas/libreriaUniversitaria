using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.Datos;
using LibreriaUniversitaria.Entidades.Excepciones;

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
        /// Realiza el proceso de login: valida credenciales y lanza excepción si no coinciden.
        /// </summary>
        /// <param name="documento">Número de documento del empleado.</param>
        /// <param name="clave">Clave del empleado.</param>
        /// <returns>Empleado logueado.</returns>
        public static Empleado Login(string documento, string clave)
        {
            Empleado emp = BuscarPorDocumentoYClave(documento, clave);

            if (emp == null)
                throw new EntidadInvalidaException("Credenciales incorrectas. Verifique el DNI y la clave.");

            return emp;
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

