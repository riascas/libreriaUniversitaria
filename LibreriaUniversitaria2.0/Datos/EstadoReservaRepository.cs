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
    public static class EstadoReservaRepository
    {
        // Obtener todos los estados disponibles desde la base
        public static List<EstadoReserva> ObtenerTodos()
        {
            List<EstadoReserva> estados = new List<EstadoReserva>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = "SELECT IdEstado, Nombre FROM EstadoReserva";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        EstadoReserva estado = new EstadoReserva
                        {
                            IdEstadoReserva = Convert.ToInt32(lector["IdEstado"]),
                            Nombre = lector["Nombre"].ToString()
                        };

                        estados.Add(estado);
                    }
                }
            }

            return estados;
        }

        // Buscar un estado por su ID
        public static EstadoReserva ObtenerPorId(int id)
        {
            EstadoReserva estado = null;

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = "SELECT IdEstado, Nombre FROM EstadoReserva WHERE IdEstado = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        estado = new EstadoReserva
                        {
                            IdEstadoReserva = Convert.ToInt32(lector["IdEstado"]),
                            Nombre = lector["Nombre"].ToString()
                        };
                    }
                }
            }

            return estado;
        }
    }
}


