using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;
using Libreria.DAL;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Clase que maneja el acceso a la tabla Editorial en la base de datos.
    /// </summary>
    public static class EditorialRepository
    {
        private static string connectionString = DbHelper.CadenaConexion;

        /// <summary>
        /// Devuelve todas las editoriales registradas en la base de datos.
        /// </summary>
        public static List<Editorial> ObtenerTodas()
        {
            List<Editorial> lista = new List<Editorial>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Editorial";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Editorial editorial = new Editorial
                    {
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Nombre = reader["Nombre"].ToString()
                    };

                    lista.Add(editorial);
                }

                reader.Close();
            }

            return lista;
        }

        /// <summary>
        /// Busca una editorial por su ID.
        /// </summary>
        public static Editorial BuscarPorId(int id)
        {
            Editorial editorial = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Editorial WHERE IdEditorial = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    editorial = new Editorial
                    {
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Nombre = reader["Nombre"].ToString()
                    };
                }

                reader.Close();
            }

            return editorial;
        }

        /// <summary>
        /// Inserta una nueva editorial en la base de datos.
        /// </summary>
        public static void Insertar(Editorial editorial)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Editorial (Nombre) VALUES (@nombre)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", editorial.Nombre);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza los datos de una editorial.
        /// </summary>
        public static void Actualizar(Editorial editorial)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Editorial SET Nombre = @nombre WHERE IdEditorial = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", editorial.Nombre);
                cmd.Parameters.AddWithValue("@id", editorial.IdEditorial);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina una editorial por su ID.
        /// </summary>
        public static void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Editorial WHERE IdEditorial = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}

