using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class EditorialBLL
    {
        private readonly EditorialDAL _dal = new EditorialDAL();
        public List<Editorial> ObtenerTodos() => _dal.ObtenerTodos();
    }
}
