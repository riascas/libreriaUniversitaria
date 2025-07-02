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
    /// Acceso a datos para los movimientos de stock.
    /// Permite registrar y consultar ingresos o egresos de libros.
    /// </summary>
    public class MovimientoStockDAL
    {
        private readonly ConexionDAL conexion;

        /// <summary>
        /// Constructor que inicializa la conexión a la base de datos.
        /// </summary>
        public MovimientoStockDAL()
        {
            conexion = new ConexionDAL();
        }

        /// <summary>
        /// Inserta un nuevo movimiento de stock en la base de datos.
        /// </summary>
        /// <param name="movimiento">Objeto MovimientoStock con los datos a guardar</param>
        public void InsertarMovimiento(MovimientoStock movimiento)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"INSERT INTO MovimientoStock 
                                 (Fecha, TipoMovimiento, Cantidad, IdLibro, IdEmpleado)
                                 VALUES (@Fecha, @TipoMovimiento, @Cantidad, @IdLibro, @IdEmpleado)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Fecha", movimiento.Fecha);
                cmd.Parameters.AddWithValue("@TipoMovimiento", movimiento.TipoMovimiento);
                cmd.Parameters.AddWithValue("@Cantidad", movimiento.Cantidad);
                cmd.Parameters.AddWithValue("@IdLibro", movimiento.IdLibro);
                cmd.Parameters.AddWithValue("@IdEmpleado", movimiento.IdEmpleado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Devuelve la lista completa de todos los movimientos registrados.
        /// </summary>
        public List<MovimientoStock> ObtenerTodos()
        {
            List<MovimientoStock> lista = new List<MovimientoStock>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"SELECT IdMovimiento, Fecha, TipoMovimiento, Cantidad, IdLibro, IdEmpleado
                                 FROM MovimientoStock";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MovimientoStock mov = new MovimientoStock
                        {
                            IdMovimiento = Convert.ToInt32(reader["IdMovimiento"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            TipoMovimiento = reader["TipoMovimiento"].ToString(),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            IdLibro = Convert.ToInt32(reader["IdLibro"]),
                            IdEmpleado = Convert.ToInt32(reader["IdEmpleado"])
                        };

                        lista.Add(mov);
                    }
                }
            }

            return lista;
        }
        /// <summary>
        /// Devuelve el stock actual de un libro específico por su Id.
        /// </summary>
        /// <param name="idLibro">Id del libro</param>
        /// <returns>Stock actual del libro</returns>
        public int ObtenerStockPorId(int idLibro)
        {
            int stock = -1;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT Stock FROM Libro WHERE IdLibro = @IdLibro";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdLibro", idLibro);

                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    stock = Convert.ToInt32(result);
                }
            }

            return stock;
        }

    }
}
