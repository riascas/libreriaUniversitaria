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
    /// Repositorio para acceder a los estados posibles de una reserva.
    /// </summary>
    public static class EstadoReservaRepository
    {
        /// <summary>
        /// Devuelve todos los estados de reserva disponibles.
        /// </summary>
        public static List<EstadoReserva> ObtenerTodos()
        {
            List<EstadoReserva> estados = new List<EstadoReserva>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = "SELECT IdEstado, Nombre FROM EstadoReserva";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        estados.Add(new EstadoReserva
                        {
                            IdEstadoReserva = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        });
                    }
                }
            }

            return estados;
        }

        /// <summary>
        /// Devuelve un estado de reserva según su identificador.
        /// </summary>
        public static EstadoReserva ObtenerPorId(int id)
        {
            EstadoReserva estado = null;

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = "SELECT IdEstado, Nombre FROM EstadoReserva WHERE IdEstado = @Id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        estado = new EstadoReserva
                        {
                            IdEstadoReserva = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                    }
                }
            }

            return estado;
        }

        /// <summary>
        /// Devuelve el ID de un estado según su nombre.
        /// </summary>
        public static int ObtenerIdPorNombre(string nombreEstado)
        {
            int id = -1;

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = "SELECT IdEstado FROM EstadoReserva WHERE Nombre = @Nombre";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nombre", nombreEstado);
                conn.Open();

                object resultado = cmd.ExecuteScalar();
                if (resultado != null)
                    id = Convert.ToInt32(resultado);
            }

            return id;
        }
    }
}
