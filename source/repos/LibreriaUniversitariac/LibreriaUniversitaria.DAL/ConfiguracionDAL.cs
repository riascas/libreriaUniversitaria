using System.Data;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class ConfiguracionDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        /// <summary>Lee la configuración (asumimos una sola fila).</summary>
        public Configuracion Obtener()
        {
            var cfg = new Configuracion();
            const string sql = "SELECT NombreLibreria, DescuentoEstudiante, DiasMaxReserva FROM Configuracion;";
            var conn = _conexion.ObtenerConexion();
            var cmd = new SqlCommand(sql, conn);
            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cfg.NombreLibreria = reader.GetString(0);
                cfg.DescuentoEstudiante = reader.GetDecimal(1);
                cfg.DiasMaxReserva = reader.GetInt32(2);
            }
            reader.Close();
            conn.Close();
            return cfg;
        }

        /// <summary>Actualiza la configuración.</summary>
        public void Guardar(Configuracion cfg)
        {
            const string sql = @"
                UPDATE Configuracion
                   SET NombreLibreria      = @nombre,
                       DescuentoEstudiante = @desc,
                       DiasMaxReserva      = @dias;";
            var conn = _conexion.ObtenerConexion();
            var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombre", cfg.NombreLibreria);
            cmd.Parameters.AddWithValue("@desc", cfg.DescuentoEstudiante);
            cmd.Parameters.AddWithValue("@dias", cfg.DiasMaxReserva);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
