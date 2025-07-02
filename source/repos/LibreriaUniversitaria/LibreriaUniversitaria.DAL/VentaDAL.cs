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
    /// Acceso a datos para la entidad Venta.
    /// </summary>
    public class VentaDAL
    {
        private readonly ConexionDAL conexion;

        public VentaDAL()
        {
            conexion = new ConexionDAL();
        }

        /// <summary>
        /// Inserta una nueva venta sin detalles.
        /// Esta versión se usa cuando no hace falta registrar el detalle en la misma operación.
        /// </summary>
        public int Insertar(Venta venta)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO Venta (IdCliente, IdReserva, Fecha, Total)
                                 VALUES (@IdCliente, @IdReserva, @Fecha, @Total);
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", venta.IdCliente);
                cmd.Parameters.AddWithValue("@IdReserva", venta.IdReserva);
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha);
                cmd.Parameters.AddWithValue("@Total", venta.Total);

                conn.Open();
                object result = cmd.ExecuteScalar();

                return Convert.ToInt32(result);
            }
        }

        /// <summary>
        /// Busca una venta por su ID.
        /// </summary>
        public Venta ObtenerPorId(int idVenta)
        {
            Venta venta = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT IdVenta, IdCliente, IdReserva, Fecha, Total
                                 FROM Venta
                                 WHERE IdVenta = @IdVenta";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        venta = new Venta
                        {
                            IdVenta = Convert.ToInt32(reader["IdVenta"]),
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            IdReserva = Convert.ToInt32(reader["IdReserva"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Total = Convert.ToDecimal(reader["Total"])
                        };
                    }
                }
            }

            return venta;
        }

        /// <summary>
        /// Devuelve todas las ventas registradas (sin detalles).
        /// </summary>
        public List<Venta> ObtenerTodas()
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT IdVenta, IdCliente, IdReserva, Fecha, Total FROM Venta";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Venta venta = new Venta
                        {
                            IdVenta = Convert.ToInt32(reader["IdVenta"]),
                            IdCliente = Convert.ToInt32(reader["IdCliente"]),
                            IdReserva = Convert.ToInt32(reader["IdReserva"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Total = Convert.ToDecimal(reader["Total"])
                        };

                        lista.Add(venta);
                    }
                }
            }

            return lista;
        }
    }
}

