using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Lógica de negocio para operaciones relacionadas con Empleado.
    /// </summary>
    public class EmpleadoBLL
    {
        private readonly EmpleadoDAL empleadoDAL;

        public EmpleadoBLL()
        {
            empleadoDAL = new EmpleadoDAL();
        }

        /// <summary>
        /// Valida las credenciales del login del empleado.
        /// Si no encuentra el usuario o la contraseña es incorrecta, lanza una excepción personalizada.
        /// </summary>
        /// <param name="documento">DNI del empleado (usuario)</param>
        /// <param name="clave">Contraseña del empleado</param>
        /// <returns>Objeto Empleado si es válido</returns>
        public Empleado ValidarLogin(int documento, string clave)
        {
            Empleado empleado = empleadoDAL.ValidarLogin(documento, clave);

            if (empleado == null)
            {
                // No se encontró un empleado con esos datos → excepción personalizada
                throw new ExcepcionLoginInvalido();
            }

            return empleado;
        }
    }
}
