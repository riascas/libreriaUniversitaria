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
    /// Clase de lógica de negocio que encapsula las operaciones relacionadas con las editoriales.
    /// Se comunica con la capa de datos (EditorialRepository).
    /// </summary>
    public static class EditorialService
    {
        /// <summary>
        /// Devuelve una lista con todas las editoriales registradas.
        /// </summary>
        public static List<Editorial> ObtenerEditoriales()
        {
            return EditorialRepository.ObtenerTodas();
        }

        /// <summary>
        /// Devuelve una editorial específica según su ID.
        /// </summary>
        public static Editorial ObtenerEditorialPorId(int id)
        {
            return EditorialRepository.BuscarPorId(id);
        }

        /// <summary>
        /// Registra una nueva editorial en el sistema.
        /// </summary>
        public static void CrearEditorial(Editorial editorial)
        {
            EditorialRepository.Insertar(editorial);
        }

        /// <summary>
        /// Actualiza los datos de una editorial existente.
        /// </summary>
        public static void ActualizarEditorial(Editorial editorial)
        {
            EditorialRepository.Actualizar(editorial);
        }

        /// <summary>
        /// Elimina una editorial por su ID.
        /// </summary>
        public static void EliminarEditorial(int id)
        {
            EditorialRepository.Eliminar(id);
        }
    }
}
