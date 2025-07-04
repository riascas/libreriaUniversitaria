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
    /// Acceso a datos para los estados de reserva.
    /// </summary>
    public class EstadoReservaDAL
    {
        private readonly ConexionDAL conexion;

        /// <summary>
        /// Constructor que inicializa la conexión a la base de datos.
        /// </summary>
        public EstadoReservaDAL()
        {
            conexion = new ConexionDAL();
        }

        /// <summary>
        /// Obtiene todos los estados de reserva desde la base de datos.
        /// </summary>
        public List<EstadoReserva> ObtenerTodos()
        {
            List<EstadoReserva> lista = new List<EstadoReserva>();

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT IdEstadoReserva, Nombre FROM EstadoReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EstadoReserva estado = new EstadoReserva
                        {
                            IdEstadoReserva = Convert.ToInt32(reader["IdEstadoReserva"]),
                            Nombre = reader["Nombre"].ToString()
                        };
                        lista.Add(estado);
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Obtiene un estado de reserva por su Id.
        /// </summary>
        public EstadoReserva ObtenerPorId(int id)
        {
            EstadoReserva estado = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = "SELECT IdEstadoReserva, Nombre FROM EstadoReserva WHERE IdEstadoReserva = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estado = new EstadoReserva
                        {
                            IdEstadoReserva = Convert.ToInt32(reader["IdEstadoReserva"]),
                            Nombre = reader["Nombre"].ToString()
                        };
                    }
                }
            }

            return estado;
        }
    }
}
