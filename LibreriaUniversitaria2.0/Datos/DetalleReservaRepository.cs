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
    /// Clase que gestiona el acceso a la tabla DetalleReserva en la base de datos.
    /// </summary>
    public static class DetalleReservaRepository
    {
        /// <summary>
        /// Inserta un detalle de reserva asociado a una reserva.
        /// </summary>
        /// <param name="detalle">Detalle de reserva (libro + cantidad)</param>
        /// <param name="idReserva">ID de la reserva a la que pertenece</param>
        public static void Insertar(DetalleReserva detalle, int idReserva)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"INSERT INTO DetalleReserva (IdReserva, IdLibro, Cantidad)
                                 VALUES (@idReserva, @idLibro, @cantidad)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
                cmd.Parameters.AddWithValue("@idLibro", detalle.Libro.IdLibro);
                cmd.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve todos los detalles de una reserva específica.
        /// </summary>
        /// <param name="idReserva">ID de la reserva</param>
        /// <returns>Lista de ítems de la reserva</returns>
        public static List<DetalleReserva> ObtenerPorReserva(int idReserva)
        {
            List<DetalleReserva> lista = new List<DetalleReserva>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT DR.IdDetalleReserva, DR.Cantidad, 
                                        L.IdLibro, L.Titulo, L.Autor, L.Precio, L.Stock, 
                                        E.IdEditorial, E.Nombre AS NombreEditorial
                                 FROM DetalleReserva DR
                                 JOIN Libro L ON DR.IdLibro = L.IdLibro
                                 JOIN Editorial E ON L.IdEditorial = E.IdEditorial
                                 WHERE DR.IdReserva = @idReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idReserva", idReserva);
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

                    DetalleReserva detalle = new DetalleReserva
                    {
                        IdDetalleReserva = Convert.ToInt32(reader["IdDetalleReserva"]),
                        Libro = libro,
                        Cantidad = Convert.ToInt32(reader["Cantidad"])
                    };

                    lista.Add(detalle);
                }

                reader.Close();
            }

            return lista;
        }
    }
}
