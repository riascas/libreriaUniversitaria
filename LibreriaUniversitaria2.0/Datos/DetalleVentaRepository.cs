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
    /// Clase que accede a los detalles de una venta (relación entre venta y libro).
    /// </summary>
    public static class DetalleVentaRepository
    {
        /// <summary>
        /// Inserta un detalle de venta en la base de datos.
        /// </summary>
        public static void Insertar(int idVenta, DetalleVenta detalle)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"INSERT INTO DetalleVenta (IdVenta, IdLibro, Cantidad, PrecioUnitario)
                                 VALUES (@idVenta, @idLibro, @cantidad, @precio)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                cmd.Parameters.AddWithValue("@idLibro", detalle.Libro.IdLibro);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve todos los ítems (detalles) asociados a una venta.
        /// </summary>
        public static List<DetalleVenta> ObtenerPorVenta(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT dv.IdDetalleVenta, dv.Cantidad, dv.PrecioUnitario,
                                        l.IdLibro, l.Titulo, l.Autor, l.Precio, l.Stock,
                                        e.IdEditorial, e.Nombre AS NombreEditorial
                                 FROM DetalleVenta dv
                                 JOIN Libro l ON dv.IdLibro = l.IdLibro
                                 JOIN Editorial e ON l.IdEditorial = e.IdEditorial
                                 WHERE dv.IdVenta = @idVenta";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Editorial editorial = new Editorial
                    {
                        IdEditorial = Convert.ToInt32(reader["IdEditorial"]),
                        Nombre = reader["NombreEditorial"].ToString()
                    };

                    Libro libro = new Libro
                    {
                        IdLibro = Convert.ToInt32(reader["IdLibro"]),
                        Titulo = reader["Titulo"].ToString(),
                        Autor = reader["Autor"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"]),
                        Stock = Convert.ToInt32(reader["Stock"]),
                        Editorial = editorial
                    };

                    DetalleVenta detalle = new DetalleVenta
                    {
                        IdDetalleVenta = Convert.ToInt32(reader["IdDetalleVenta"]),
                        Libro = libro,
                        Cantidad = Convert.ToInt32(reader["Cantidad"]),
                        PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"])
                    };

                    lista.Add(detalle);
                }

                reader.Close();
            }

            return lista;
        }
    }
}
