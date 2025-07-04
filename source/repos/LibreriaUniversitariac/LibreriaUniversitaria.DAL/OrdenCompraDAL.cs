using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class OrdenCompraDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<OrdenCompra> ObtenerTodos()
        {
            // Stub: retornar lista vacía
            return new List<OrdenCompra>();
        }

        public void Eliminar(int idOrden)
        {
            // Stub: implementar eliminación en BD
        }
    }
}
