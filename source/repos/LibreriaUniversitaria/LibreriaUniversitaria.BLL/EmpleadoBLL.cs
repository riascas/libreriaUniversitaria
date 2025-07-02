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
    public class EmpleadoBLL
    {
        private readonly EmpleadoDAL empleadoDAL;

        public EmpleadoBLL()
        {
            empleadoDAL = new EmpleadoDAL();
        }

        /// <summary>
        /// Llama al DAL para validar login
        /// </summary>
        public Empleado ValidarLogin(int documento, string clave)
        {
            return empleadoDAL.ValidarLogin(documento, clave);
        }
    }
}

