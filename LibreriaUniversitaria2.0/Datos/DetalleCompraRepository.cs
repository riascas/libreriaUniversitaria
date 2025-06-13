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
    /// Clase que accede a los detalles de compra (relación entre orden y libro).
    /// </summary>
    public static class DetalleCompraRepository
    {
        /// <summary>
        /// Inserta un detalle en una orden de compra.
        /// </summary>
        public static void Insertar(int idOrden, DetalleCompra detalle)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"INSERT INTO DetalleCompra (IdOrdenCompra, IdLibro, Cantidad, PrecioUnitario)
                                 VALUES (@idOrden, @idLibro, @cantidad, @precio)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idOrden", idOrden);
                cmd.Parameters.AddWithValue("@idLibro", detalle.Libro.IdLibro);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@precio", detalle.PrecioUnitario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve todos los detalles asociados a una orden de compra.
        /// </summary>
        public static List<DetalleCompra> ObtenerPorOrden(int idOrden)
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT d.IdDetalleCompra, d.Cantidad, d.PrecioUnitario,
                                        l.IdLibro, l.Titulo, l.Autor, l.Precio, l.Stock,
                                        e.IdEditorial, e.Nombre AS NombreEditorial
                                 FROM DetalleCompra d
                                 JOIN Libro l ON d.IdLibro = l.IdLibro
                                 JOIN Editorial e ON l.IdEditorial = e.IdEditorial
                                 WHERE d.IdOrdenCompra = @idOrden";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idOrden", idOrden);
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

                    DetalleCompra detalle = new DetalleCompra
                    {
                        IdDetalleCompra = Convert.ToInt32(reader["IdDetalleCompra"]),
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
