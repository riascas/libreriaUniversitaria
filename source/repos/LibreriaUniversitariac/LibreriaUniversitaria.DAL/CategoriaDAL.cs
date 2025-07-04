using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class CategoriaDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<Categoria> ObtenerTodos()
        {
            var list = new List<Categoria>();
            const string sql = "SELECT IdCategoria, Nombre FROM Categoria;";
            using (var c = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, c))
            {
                c.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new Categoria
                        {
                            IdCategoria = r.GetInt32(0),
                            Nombre = r.GetString(1)
                        });
            }
            return list;
        }
    }
}
