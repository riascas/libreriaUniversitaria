using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class EditorialDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<Editorial> ObtenerTodos()
        {
            var list = new List<Editorial>();
            const string sql = "SELECT IdEditorial, Nombre, Email FROM Editorial;";
            using (var c = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, c))
            {
                c.Open();
                using (var r = cmd.ExecuteReader())
                    while (r.Read())
                        list.Add(new Editorial
                        {
                            IdEditorial = r.GetInt32(0),
                            Nombre = r.GetString(1),
                            Email = r.GetString(2)
                        });
            }
            return list;
        }
    }
}
