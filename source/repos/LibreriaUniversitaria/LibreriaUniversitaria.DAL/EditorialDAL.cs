using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    /// <summary>
    /// Acceso a datos para la entidad Editorial.
    /// </summary>
    public class EditorialDAL
    {
        private readonly ConexionDAL conexion;

        public EditorialDAL()
        {
            conexion = new ConexionDAL();
        }

        // Inserta una nueva editorial en la base de datos
        public void Insertar(Editorial editorial)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"INSERT INTO Editorial (Nombre, Email)
                                 VALUES (@Nombre, @Email)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", editorial.Nombre);
                cmd.Parameters.AddWithValue("@Email", editorial.Email);

                cmd.ExecuteNonQuery();
            }
        }

        // Devuelve la lista de todas las editoriales
        public List<Editorial> ObtenerTodas()
        {
            List<Editorial> lista = new List<Editorial>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"SELECT IdEditorial, Nombre, Email FROM Editorial";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Editorial editorial = new Editorial
                    {
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Nombre = reader["Nombre"].ToString(),
                        Email = reader["Email"].ToString()
                    };

                    lista.Add(editorial);
                }
            }

            return lista;
        }

        // Devuelve una editorial específica por ID
        public Editorial ObtenerPorId(int id)
        {
            Editorial editorial = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"SELECT IdEditorial, Nombre, Email
                                 FROM Editorial
                                 WHERE IdEditorial = @IdEditorial";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEditorial", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    editorial = new Editorial
                    {
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Nombre = reader["Nombre"].ToString(),
                        Email = reader["Email"].ToString()
                    };
                }
            }

            return editorial;
        }

        // Actualiza los datos de una editorial
        public void Actualizar(Editorial editorial)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"UPDATE Editorial
                                 SET Nombre = @Nombre, Email = @Email
                                 WHERE IdEditorial = @IdEditorial";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", editorial.Nombre);
                cmd.Parameters.AddWithValue("@Email", editorial.Email);
                cmd.Parameters.AddWithValue("@IdEditorial", editorial.IdEditorial);

                cmd.ExecuteNonQuery();
            }
        }

        // Elimina una editorial por su ID
        public void Eliminar(int id)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = @"DELETE FROM Editorial WHERE IdEditorial = @IdEditorial";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdEditorial", id);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
