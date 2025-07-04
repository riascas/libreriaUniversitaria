using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class EmpleadoBLL
    {
        private readonly EmpleadoDAL _dal = new EmpleadoDAL();

        public List<Empleado> ObtenerTodos() => _dal.ObtenerTodos();
        public Empleado ObtenerPorId(int id) => _dal.ObtenerPorId(id);
        public bool ValidarLogin(string em, string pw) => _dal.ValidarLogin(em, pw);
        public void Alta(Empleado e) => _dal.Insertar(e);
        public void Modificar(Empleado e) => _dal.Actualizar(e);
        public void Eliminar(int idEmp, int idPers) => _dal.Eliminar(idEmp, idPers);
    }
}
