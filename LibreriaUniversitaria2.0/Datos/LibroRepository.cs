using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace Libreria.DAL
{
    /// <summary>
    /// Clase que maneja el acceso a la tabla Libro en la base de datos.
    /// </summary>
    public static class LibroRepository
    {
        // Cadena de conexión obtenida desde App.config
        private static string connectionString = DbHelper.CadenaConexion;

        /// <summary>
        /// Devuelve todos los libros existentes en la base de datos.
        /// </summary>
        public static List<Libro> ObtenerTodos()
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Libro";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"])
                    };

                    lista.Add(libro);
                }

                reader.Close();
            }

            return lista;
        }

        /// <summary>
        /// Busca un libro por su ID.
        /// </summary>
        public static Libro BuscarPorId(int id)
        {
            Libro libro = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Libro WHERE IdLibro = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"])
                    };
                }

                reader.Close();
            }

            return libro;
        }

        /// <summary>
        /// Inserta un nuevo libro en la base de datos.
        /// </summary>
        public static void Insertar(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Libro (Titulo, Autor, Stock, Precio, IdEditorial) VALUES (@titulo, @autor, @stock, @precio, @idEditorial)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@autor", libro.Autor);
                cmd.Parameters.AddWithValue("@stock", libro.Stock);
                cmd.Parameters.AddWithValue("@precio", libro.Precio);
                cmd.Parameters.AddWithValue("@idEditorial", libro.IdEditorial);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza un libro existente.
        /// </summary>
        public static void Actualizar(Libro libro)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Libro SET Titulo = @titulo, Autor = @autor, Stock = @stock, Precio = @precio, IdEditorial = @idEditorial WHERE IdLibro = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@autor", libro.Autor);
                cmd.Parameters.AddWithValue("@stock", libro.Stock);
                cmd.Parameters.AddWithValue("@precio", libro.Precio);
                cmd.Parameters.AddWithValue("@idEditorial", libro.IdEditorial);
                cmd.Parameters.AddWithValue("@id", libro.IdLibro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina un libro por su ID.
        /// </summary>
        public static void Eliminar(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Libro WHERE IdLibro = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
