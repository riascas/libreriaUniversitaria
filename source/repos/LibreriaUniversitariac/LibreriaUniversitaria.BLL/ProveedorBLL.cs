using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class ProveedorBLL
    {
        private readonly ProveedorDAL _dal = new ProveedorDAL();

        public List<Proveedor> ObtenerTodos() => _dal.ObtenerTodos();
        public void Alta(Proveedor p) => _dal.Insertar(p);
        public void Modificar(Proveedor p) => _dal.Actualizar(p);
        public void Eliminar(int id) => _dal.Eliminar(id);
    }
}
