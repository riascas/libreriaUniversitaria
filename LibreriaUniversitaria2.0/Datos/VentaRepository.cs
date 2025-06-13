using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Libreria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.Datos
{
    /// <summary>
    /// Clase encargada del acceso a datos para las ventas.
    /// </summary>
    public static class VentaRepository
    {
        /// <summary>
        /// Registra una venta en la base de datos a partir de una reserva ya confirmada.
        /// </summary>
        public static void RegistrarVenta(Venta venta)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insertar la venta en la tabla Venta
                    SqlCommand cmdVenta = new SqlCommand(
                        @"INSERT INTO Venta (Fecha, IdEmpleado, IdReserva, Total)
                          VALUES (@Fecha, @IdEmpleado, @IdReserva, @Total);
                          SELECT SCOPE_IDENTITY();", conn, transaction);

                    cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha);
                    cmdVenta.Parameters.AddWithValue("@IdEmpleado", venta.Empleado.IdEmpleado);
                    cmdVenta.Parameters.AddWithValue("@IdReserva", venta.Reserva.IdReserva);
                    cmdVenta.Parameters.AddWithValue("@Total", venta.Total);

                    int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());
                    venta.IdVenta = idVenta;

                    // Insertar los detalles de la venta
                    foreach (var item in venta.Reserva.Detalles)
                    {
                        SqlCommand cmdDetalle = new SqlCommand(
                            @"INSERT INTO DetalleVenta (IdVenta, IdLibro, Cantidad, PrecioUnitario)
                              VALUES (@IdVenta, @IdLibro, @Cantidad, @PrecioUnitario);", conn, transaction);

                        cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@IdLibro", item.Libro.IdLibro);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", item.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", item.Libro.Precio); // precio al momento

                        cmdDetalle.ExecuteNonQuery();
                    }

                    // Actualizar estado de la reserva a "Vendida"
                    ReservaRepository.ActualizarEstado(venta.Reserva.IdReserva, EstadoReservaRepository.ObtenerIdPorNombre("Vendida"), conn, transaction);

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al registrar la venta: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Obtiene todas las ventas registradas en el sistema.
        /// </summary>
        public static List<Venta> ObtenerTodas()
        {
            var lista = new List<Venta>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"SELECT v.IdVenta, v.Fecha, v.Total,
                             e.IdEmpleado, e.Nombre AS NombreEmpleado,
                             r.IdReserva
                      FROM Venta v
                      JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado
                      JOIN Reserva r ON v.IdReserva = r.IdReserva", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var venta = new Venta
                        {
                            IdVenta = Convert.ToInt32(reader["IdVenta"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Total = Convert.ToDecimal(reader["Total"]),
                            Empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = reader["NombreEmpleado"].ToString()
                            },
                            Reserva = ReservaRepository.ObtenerPorId(Convert.ToInt32(reader["IdReserva"]))
                        };

                        lista.Add(venta);
                    }
                }
            }

            return lista;
        }
    }
}
