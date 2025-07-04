using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class OrdenCompraBLL
    {
        private readonly OrdenCompraDAL _dal = new OrdenCompraDAL();

        public List<OrdenCompra> ObtenerTodos()
        {
            return _dal.ObtenerTodos();
        }

        public void Eliminar(int idOrden)
        {
            _dal.Eliminar(idOrden);
        }
    }
}