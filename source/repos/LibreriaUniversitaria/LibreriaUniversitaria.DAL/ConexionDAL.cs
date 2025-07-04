using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;      // Para ConfigurationManager
using System.Data.SqlClient;     // Para SqlConnection

namespace LibreriaUniversitaria.DAL
{
    public class ConexionDAL
    {
        private readonly string _cadenaConexion;

        // Constructor: obtiene la cadena desde el App.config
        public ConexionDAL()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
        }

        /// <summary>
        /// Devuelve un objeto SqlConnection listo para usar.
        /// No abre la conexión, solo la instancia.
        /// </summary>
        /// <returns>Objeto SqlConnection</returns>
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(_cadenaConexion);
        }

        /// <summary>
        /// Método opcional para verificar la conexión (puede servir para pruebas iniciales).
        /// </summary>
        public void ProbarConexion()
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    Console.WriteLine(" Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(" Error al conectar: " + ex.Message);
                }
            }
        }
    }
}

