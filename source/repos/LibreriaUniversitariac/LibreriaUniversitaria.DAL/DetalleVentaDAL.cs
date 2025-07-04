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
    /// Clase que maneja el acceso a datos para los detalles de cada venta.
    /// </summary>
    public class DetalleVentaDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        /// <summary>
        /// Constructor. Inicializa la conexión a la base de datos.
        /// </summary>
        public DetalleVentaDAL()
        {
            _conexion = new ConexionDAL();
        }

        /// <summary>
        /// Inserta un nuevo detalle de venta en la tabla correspondiente.
        /// </summary>
        /// <param name="detalle">DetalleVenta con todos los datos del libro vendido</param>
        public void Insertar(DetalleVenta detalle)
        {
            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO DetalleVenta 
                                (IdVenta, IdLibro, Cantidad, PrecioUnitario)
                                VALUES (@IdVenta, @IdLibro, @Cantidad, @PrecioUnitario)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVenta", detalle.IdVenta);
                cmd.Parameters.AddWithValue("@IdLibro", detalle.IdLibro);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve todos los detalles de venta asociados a un Id de venta específico.
        /// </summary>
        /// <param name="idVenta">Identificador de la venta</param>
        /// <returns>Lista de detalles de venta correspondientes</returns>
        public List<DetalleVenta> ObtenerPorVenta(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using (SqlConnection conn = _conexion.ObtenerConexion())
            {
                string query = @"SELECT dv.IdDetalleVenta, dv.IdVenta, dv.IdLibro, dv.Cantidad, dv.PrecioUnitario,
                                        l.Titulo, l.Autor, l.ISBN
                                 FROM DetalleVenta dv
                                 INNER JOIN Libro l ON dv.IdLibro = l.IdLibro
                                 WHERE dv.IdVenta = @IdVenta";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DetalleVenta detalle = new DetalleVenta
                        {
                            IdDetalleVenta = Convert.ToInt32(reader["IdDetalleVenta"]),
                            IdVenta = Convert.ToInt32(reader["IdVenta"]),
                            IdLibro = Convert.ToInt32(reader["IdLibro"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            PrecioUnitario = Convert.ToDecimal(reader["PrecioUnitario"]),
                            Libro = new Libro
                            {
                                IdLibro = Convert.ToInt32(reader["IdLibro"]),
                                Titulo = reader["Titulo"].ToString(),
                                Autor = reader["Autor"].ToString(),
                                ISBN = reader["ISBN"].ToString()
                            }
                        };

                        lista.Add(detalle);
                    }
                }
            }

            return lista;
        }
    }
}

