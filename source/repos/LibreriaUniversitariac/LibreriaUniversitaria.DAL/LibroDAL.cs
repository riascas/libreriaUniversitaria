using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class LibroDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<Libro> ObtenerTodos()
        {
            var lista = new List<Libro>();
            const string sql = @"
                SELECT l.IdLibro, l.Titulo, l.ISBN, l.Autor,
                       l.IdEditorial, e.Nombre AS NombreEditorial,
                       l.IdCategoria, c.Nombre AS NombreCategoria,
                       l.Stock, l.Precio, l.Activo
                  FROM Libro l
             LEFT JOIN Editorial e ON l.IdEditorial = e.IdEditorial
             LEFT JOIN Categoria  c ON l.IdCategoria  = c.IdCategoria
              ORDER BY l.Titulo;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(new Libro
                        {
                            IdLibro = rdr.GetInt32(0),
                            Titulo = rdr.GetString(1),
                            ISBN = rdr.GetString(2),
                            Autor = rdr.GetString(3),
                            IdEditorial = rdr.IsDBNull(4) ? 0 : rdr.GetInt32(4),
                            Categoria = rdr.IsDBNull(7) ? null : rdr.GetString(7),
                            IdCategoria = rdr.GetInt32(6),
                            Stock = rdr.GetInt32(8),
                            Precio = rdr.GetDecimal(9),
                            Activo = rdr.GetBoolean(10)
                        });
                    }
                }
            }
            return lista;
        }

        public Libro ObtenerPorId(int idLibro)
        {
            const string sql = @"
                SELECT IdLibro, Titulo, ISBN, Autor,
                       IdEditorial, IdCategoria, Stock, Precio, Activo
                  FROM Libro
                 WHERE IdLibro = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idLibro);
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (rdr.Read())
                        return new Libro
                        {
                            IdLibro = rdr.GetInt32(0),
                            Titulo = rdr.GetString(1),
                            ISBN = rdr.GetString(2),
                            Autor = rdr.GetString(3),
                            IdEditorial = rdr.GetInt32(4),
                            IdCategoria = rdr.GetInt32(5),
                            Stock = rdr.GetInt32(6),
                            Precio = rdr.GetDecimal(7),
                            Activo = rdr.GetBoolean(8)
                        };
                }
            }
            return null;
        }

        public void Insertar(Libro l)
        {
            const string sql = @"
                INSERT INTO Libro
                  (Titulo, ISBN, Autor, IdEditorial, IdCategoria, Stock, Precio, Activo)
                VALUES
                  (@t, @i, @a, @ed, @cat, @stk, @pre, @act);";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@t", l.Titulo);
                cmd.Parameters.AddWithValue("@i", l.ISBN);
                cmd.Parameters.AddWithValue("@a", l.Autor);
                cmd.Parameters.AddWithValue("@ed", l.IdEditorial);
                cmd.Parameters.AddWithValue("@cat", l.IdCategoria);
                cmd.Parameters.AddWithValue("@stk", l.Stock);
                cmd.Parameters.AddWithValue("@pre", l.Precio);
                cmd.Parameters.AddWithValue("@act", l.Activo);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Libro l)
        {
            const string sql = @"
                UPDATE Libro
                   SET Titulo      = @t,
                       ISBN        = @i,
                       Autor       = @a,
                       IdEditorial = @ed,
                       IdCategoria = @cat,
                       Stock       = @stk,
                       Precio      = @pre,
                       Activo      = @act
                 WHERE IdLibro = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@t", l.Titulo);
                cmd.Parameters.AddWithValue("@i", l.ISBN);
                cmd.Parameters.AddWithValue("@a", l.Autor);
                cmd.Parameters.AddWithValue("@ed", l.IdEditorial);
                cmd.Parameters.AddWithValue("@cat", l.IdCategoria);
                cmd.Parameters.AddWithValue("@stk", l.Stock);
                cmd.Parameters.AddWithValue("@pre", l.Precio);
                cmd.Parameters.AddWithValue("@act", l.Activo);
                cmd.Parameters.AddWithValue("@id", l.IdLibro);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idLibro)
        {
            const string sql = "DELETE FROM Libro WHERE IdLibro = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idLibro);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void CambiarEstado(int idLibro, bool nuevoEstado)
        {
            const string sql = @"
                UPDATE Libro
                   SET Activo = @act
                 WHERE IdLibro = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@act", nuevoEstado);
                cmd.Parameters.AddWithValue("@id", idLibro);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarStock(int idLibro, int delta)
        {
            const string sql = @"
                UPDATE Libro
                   SET Stock = Stock + @d
                 WHERE IdLibro = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@d", delta);
                cmd.Parameters.AddWithValue("@id", idLibro);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Libro> BuscarPorTitulo(string texto)
        {
            // → ya la rellenaste según el ejemplo anterior
            throw new NotImplementedException();
        }
        public List<Libro> BuscarPorAutor(string texto) => BuscarPorCampo("Autor", texto);
        public List<Libro> BuscarPorISBN(string texto) => BuscarPorCampo("ISBN", texto);
        public List<Libro> BuscarPorCategoria(string texto) => BuscarPorCampo("NombreCategoria", texto, joinCategoria: true);
        public List<Libro> BuscarPorEditorial(string texto) => BuscarPorCampo("NombreEditorial", texto, joinEditorial: true);

        // Método interno para no repetir SQL
        private List<Libro> BuscarPorCampo(string campo, string texto,
            bool joinEditorial = false, bool joinCategoria = false)
        {
            var lista = new List<Libro>();
            var from = @"
                FROM Libro l
           LEFT JOIN Editorial e ON l.IdEditorial = e.IdEditorial
           LEFT JOIN Categoria  c ON l.IdCategoria  = c.IdCategoria";
            var sql = $@"
                SELECT l.IdLibro, l.Titulo, l.ISBN, l.Autor,
                       l.IdEditorial, e.Nombre,
                       l.IdCategoria, c.Nombre,
                       l.Stock, l.Precio, l.Activo
                  {from}
                 WHERE {campo} LIKE '%' + @txt + '%'
              ORDER BY l.Titulo;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@txt", texto);
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        lista.Add(new Libro
                        {
                            IdLibro = rdr.GetInt32(0),
                            Titulo = rdr.GetString(1),
                            ISBN = rdr.GetString(2),
                            Autor = rdr.GetString(3),
                            IdEditorial = rdr.GetInt32(4),
                            Categoria = rdr.GetString(7),
                            IdCategoria = rdr.GetInt32(6),
                            Stock = rdr.GetInt32(8),
                            Precio = rdr.GetDecimal(9),
                            Activo = rdr.GetBoolean(10)
                        });
            }
            return lista;
        }
    }
}
