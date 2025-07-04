using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Encargada de aplicar las reglas de negocio relacionadas con las editoriales.
    /// </summary>
    public class EditorialBLL
    {
        private readonly EditorialDAL editorialDAL;

        public EditorialBLL()
        {
            editorialDAL = new EditorialDAL();
        }

        // Método para agregar una nueva editorial
        public void AgregarEditorial(Editorial editorial)
        {
            if (string.IsNullOrWhiteSpace(editorial.Nombre))
                throw new ArgumentException("El nombre de la editorial no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(editorial.Email))
                throw new ArgumentException("El email de la editorial no puede estar vacío.");

            editorialDAL.Insertar(editorial);
        }

        // Devuelve la lista de todas las editoriales guardadas
        public List<Editorial> ObtenerTodas()
        {
            return editorialDAL.ObtenerTodas();
        }

        // Devuelve una editorial específica por su ID
        public Editorial ObtenerPorId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID debe ser mayor a cero.");

            return editorialDAL.ObtenerPorId(id);
        }

        // Actualiza los datos de una editorial existente
        public void ActualizarEditorial(Editorial editorial)
        {
            if (editorial.IdEditorial <= 0)
                throw new ArgumentException("El ID de la editorial no es válido.");

            if (string.IsNullOrWhiteSpace(editorial.Nombre))
                throw new ArgumentException("El nombre no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(editorial.Email))
                throw new ArgumentException("El email no puede estar vacío.");

            editorialDAL.Actualizar(editorial);
        }

        // Elimina una editorial por su ID
        public void EliminarEditorial(int id)
        {
            if (id <= 0)
                throw new ArgumentException("El ID de la editorial no es válido.");

            editorialDAL.Eliminar(id);
        }
    }
}
