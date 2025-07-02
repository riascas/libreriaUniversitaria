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
    public class EmpleadoDAL
    {
        private readonly ConexionDAL conexion;

        public EmpleadoDAL()
        {
            conexion = new ConexionDAL();
        }

        /// <summary>
        /// Valida login del empleado buscando por DNI (tabla Persona) y Clave (tabla Empleado)
        /// </summary>
        public Empleado ValidarLogin(int documento, string clave)
        {
            Empleado empleado = null;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                string query = @"
                    SELECT 
                        e.IdEmpleado,
                        e.IdRol,
                        p.DNI,
                        e.Clave,
                        p.Nombre,
                        p.Apellido,
                        p.Email
                    FROM Empleado e
                    INNER JOIN Persona p ON e.IdPersona = p.IdPersona
                    WHERE p.DNI = @dni AND e.Clave = @clave";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dni", documento);
                cmd.Parameters.AddWithValue("@clave", clave);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        empleado = new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                            Dni = Convert.ToInt32(reader["DNI"]),
                            Clave = reader["Clave"].ToString(),
                            IdRol = Convert.ToInt32(reader["IdRol"]),
                            Nombre = reader["Nombre"].ToString(),
                            Apellido = reader["Apellido"].ToString(),
                            Email = reader["Email"].ToString()
                        };
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al validar login: " + ex.Message);
                }
            }

            return empleado;
        }
    }
}

