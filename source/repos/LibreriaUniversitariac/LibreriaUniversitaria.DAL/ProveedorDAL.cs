using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.DAL
{
    public class ProveedorDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public List<Proveedor> ObtenerTodos()
        {
            var lista = new List<Proveedor>();
            const string sql = @"
                SELECT IdProveedor, RazonSocial, CUIT, Telefono
                  FROM Proveedor;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                    while (rdr.Read())
                        lista.Add(new Proveedor
                        {
                            IdProveedor = rdr.GetInt32(0),
                            RazonSocial = rdr.GetString(1),
                            CUIT = rdr.GetString(2),
                            Telefono = rdr.GetString(3)
                        });
            }
            return lista;
        }

        public void Insertar(Proveedor p)
        {
            const string sql = @"
                INSERT INTO Proveedor (RazonSocial, CUIT, Telefono)
                VALUES (@razon, @cuit, @tel);";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@razon", p.RazonSocial);
                cmd.Parameters.AddWithValue("@cuit", p.CUIT);
                cmd.Parameters.AddWithValue("@tel", p.Telefono);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Proveedor p)
        {
            const string sql = @"
                UPDATE Proveedor
                   SET RazonSocial = @razon,
                       CUIT        = @cuit,
                       Telefono    = @tel
                 WHERE IdProveedor = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@razon", p.RazonSocial);
                cmd.Parameters.AddWithValue("@cuit", p.CUIT);
                cmd.Parameters.AddWithValue("@tel", p.Telefono);
                cmd.Parameters.AddWithValue("@id", p.IdProveedor);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int idProveedor)
        {
            const string sql = "DELETE FROM Proveedor WHERE IdProveedor = @id;";
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", idProveedor);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
