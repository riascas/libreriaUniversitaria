using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    /// <summary>
    /// Esta clase se encarga de acceder a los datos de los libros.
    /// </summary>
    public class LibroDAL
    {
        private readonly ConexionDAL conexion;

        public LibroDAL()
        {
            conexion = new ConexionDAL();
        }

        // Agrega un nuevo libro a la base de datos
        public void Insertar(Libro libro)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Libro (Titulo, ISBN, IdEditorial, Stock, Precio, Activo, Autor)
                                 VALUES (@Titulo, @ISBN, @IdEditorial, @Stock, @Precio, @Activo, @Autor)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@ISBN", libro.ISBN);
                cmd.Parameters.AddWithValue("@IdEditorial", libro.IdEditorial);
                cmd.Parameters.AddWithValue("@Stock", libro.Stock);
                cmd.Parameters.AddWithValue("@Precio", libro.Precio);
                cmd.Parameters.AddWithValue("@Activo", libro.Activo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Devuelve todos los libros con datos de editorial
        public List<Libro> ObtenerTodos()
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT L.IdLibro, L.Titulo, L.ISBN, L.Stock, L.Precio, L.Activo, L.Autor,
                                        L.IdEditorial, E.Nombre AS NombreEditorial
                                 FROM Libro L
                                 INNER JOIN Editorial E ON L.IdEditorial = E.IdEditorial";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Activo = Convert.ToBoolean(reader["Activo"]),
                        Autor = reader["Autor"].ToString(),
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Editorial = new Editorial
                        {
                            IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                            Nombre = reader["NombreEditorial"].ToString()
                        }
                    };
                    lista.Add(libro);
                }

                reader.Close();
            }

            return lista;
        }

        // Actualiza todos los datos de un libro
        public void Actualizar(Libro libro)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"UPDATE Libro
                                 SET Titulo = @Titulo,
                                     ISBN = @ISBN,
                                     IdEditorial = @IdEditorial,
                                     Stock = @Stock,
                                     Precio = @Precio,
                                     Activo = @Activo,
                                     Autor = @Autor
                                 WHERE IdLibro = @IdLibro";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                cmd.Parameters.AddWithValue("@ISBN", libro.ISBN);
                cmd.Parameters.AddWithValue("@IdEditorial", libro.IdEditorial);
                cmd.Parameters.AddWithValue("@Stock", libro.Stock);
                cmd.Parameters.AddWithValue("@Precio", libro.Precio);
                cmd.Parameters.AddWithValue("@Activo", libro.Activo);
                cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                cmd.Parameters.AddWithValue("@IdLibro", libro.IdLibro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Elimina un libro por su ID
        public void Eliminar(int idLibro)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "DELETE FROM Libro WHERE IdLibro = @IdLibro";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Busca libros por ISBN
        public List<Libro> BuscarPorISBN(string isbn)
        {
            return BuscarPorCampo("L.ISBN", isbn);
        }

        // Busca libros por título o autor (cualquier coincidencia)
        public List<Libro> BuscarPorTituloOAutor(string texto)
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT L.IdLibro, L.Titulo, L.ISBN, L.Stock, L.Precio, L.Activo, L.Autor,
                                        L.IdEditorial, E.Nombre AS NombreEditorial
                                 FROM Libro L
                                 INNER JOIN Editorial E ON L.IdEditorial = E.IdEditorial
                                 WHERE L.Titulo LIKE @texto OR L.Autor LIKE @texto";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Activo = Convert.ToBoolean(reader["Activo"]),
                        Autor = reader["Autor"].ToString(),
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Editorial = new Editorial
                        {
                            IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                            Nombre = reader["NombreEditorial"].ToString()
                        }
                    };
                    lista.Add(libro);
                }

                reader.Close();
            }

            return lista;
        }

        // Busca un libro por ID
        public Libro BuscarPorId(int idLibro)
        {
            Libro libro = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT L.IdLibro, L.Titulo, L.ISBN, L.Stock, L.Precio, L.Activo, L.Autor,
                                        L.IdEditorial, E.Nombre AS NombreEditorial
                                 FROM Libro L
                                 INNER JOIN Editorial E ON L.IdEditorial = E.IdEditorial
                                 WHERE L.IdLibro = @IdLibro";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Activo = Convert.ToBoolean(reader["Activo"]),
                        Autor = reader["Autor"].ToString(),
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Editorial = new Editorial
                        {
                            IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                            Nombre = reader["NombreEditorial"].ToString()
                        }
                    };
                }

                reader.Close();
            }

            return libro;
        }

        // Cambia el estado de un libro (activo o inactivo)
        public void CambiarEstado(int idLibro, bool nuevoEstado)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"UPDATE Libro
                                 SET Activo = @Activo
                                 WHERE IdLibro = @IdLibro";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Activo", nuevoEstado);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Actualiza solo el stock del libro
        public void ActualizarStock(int idLibro, int nuevoStock)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"UPDATE Libro
                                 SET Stock = @Stock
                                 WHERE IdLibro = @IdLibro";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Stock", nuevoStock);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        // Busca libros por título
        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return BuscarPorCampo("L.Titulo", titulo);
        }

        // Busca libros por autor
        public List<Libro> BuscarPorAutor(string autor)
        {
            return BuscarPorCampo("L.Autor", autor);
        }

        // Busca libros por editorial (coincide con el nombre de la editorial)
        public List<Libro> BuscarPorEditorial(string editorial)
        {
            return BuscarPorCampo("E.Nombre", editorial);
        }

        // Método auxiliar para buscar por campo específico (ISBN, Autor, Editorial)
        private List<Libro> BuscarPorCampo(string campo, string valor)
        {
            List<Libro> lista = new List<Libro>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = $@"SELECT L.IdLibro, L.Titulo, L.ISBN, L.Stock, L.Precio, L.Activo, L.Autor,
                                         L.IdEditorial, E.Nombre AS NombreEditorial
                                  FROM Libro L
                                  INNER JOIN Editorial E ON L.IdEditorial = E.IdEditorial
                                  WHERE {campo} LIKE @valor";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Libro libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        ISBN = reader["ISBN"].ToString(),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Activo = Convert.ToBoolean(reader["Activo"]),
                        Autor = reader["Autor"].ToString(),
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Editorial = new Editorial
                        {
                            IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                            Nombre = reader["NombreEditorial"].ToString()
                        }
                    };
                    lista.Add(libro);
                }

                reader.Close();
            }

            
            return lista;
        }
    }
}


