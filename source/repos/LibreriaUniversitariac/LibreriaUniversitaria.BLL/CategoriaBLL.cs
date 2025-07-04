using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class CategoriaBLL
    {
        private readonly CategoriaDAL _dal = new CategoriaDAL();
        public List<Categoria> ObtenerTodos() => _dal.ObtenerTodos();
    }
}
