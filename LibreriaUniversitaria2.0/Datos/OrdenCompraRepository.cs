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
    /// Clase que gestiona el acceso a la tabla OrdenCompra en la base de datos.
    /// </summary>
    public static class OrdenCompraRepository
    {
        /// <summary>
        /// Inserta una nueva orden de compra con sus detalles.
        /// </summary>
        /// <param name="orden">La orden a insertar</param>
        /// <returns>ID generado</returns>
        public static int Insertar(OrdenCompra orden)
        {
            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"INSERT INTO OrdenCompra (Fecha, IdEmpleado)
                                 VALUES (@fecha, @idEmpleado);
                                 SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@fecha", orden.Fecha);
                cmd.Parameters.AddWithValue("@idEmpleado", orden.Empleado.IdEmpleado);

                conn.Open();
                int idOrden = Convert.ToInt32(cmd.ExecuteScalar());

                // Insertar detalles
                foreach (var item in orden.Items)
                {
                    DetalleCompraRepository.Insertar(idOrden, item); // OK si el método está bien definido
                }

                return idOrden;
            }
        }

        /// <summary>
        /// Devuelve todas las órdenes de compra con sus detalles.
        /// </summary>
        public static List<OrdenCompra> ObtenerTodas()
        {
            List<OrdenCompra> lista = new List<OrdenCompra>();

            using (SqlConnection conn = DbHelper.ObtenerConexion())
            {
                string query = @"SELECT o.IdOrdenCompra, o.Fecha,
                                        e.IdEmpleado, e.Nombre, e.Apellido
                                 FROM OrdenCompra o
                                 JOIN Empleado e ON o.IdEmpleado = e.IdEmpleado";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        OrdenCompra orden = new OrdenCompra
                        {
                            IdOrdenCompra = Convert.ToInt32(reader["IdOrdenCompra"]),
                            Fecha = Convert.ToDateTime(reader["Fecha"]),
                            Empleado = new Empleado
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString()
                            },
                            // ⚠ Asegurate de tener implementado este método
                            Items = DetalleCompraRepository.ObtenerPorOrden(Convert.ToInt32(reader["IdOrdenCompra"]))
                        };

                        lista.Add(orden);
                    }
                }
            }

            return lista;
        }
    }
}
