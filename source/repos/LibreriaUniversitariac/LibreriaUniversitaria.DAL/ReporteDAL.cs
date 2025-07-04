using System;
using System.Data;
using System.Data.SqlClient;

namespace LibreriaUniversitaria.DAL
{
    public class ReporteDAL
    {
        private readonly ConexionDAL _conexion = new ConexionDAL();

        public DataTable VentasPorRegion(DateTime desde, DateTime hasta)
        {
            const string sql = @"
                SELECT d.Provincia AS Region, COUNT(*) AS CantidadVentas
                FROM Venta v
                JOIN Reserva r ON v.IdReserva = r.IdReserva
                JOIN Cliente c ON r.IdCliente = c.IdCliente
                JOIN Persona p ON c.IdPersona = p.IdPersona
                JOIN Domicilio d ON p.IdDomicilio = d.IdDomicilio
                WHERE v.FechaVenta BETWEEN @desde AND @hasta
                GROUP BY d.Provincia;";
            return EjecutarDataTable(sql, desde, hasta);
        }

        public DataTable VentasPorLibro(DateTime desde, DateTime hasta)
        {
            const string sql = @"
                SELECT l.Titulo, SUM(dr.Cantidad) AS TotalVendidos
                FROM Venta v
                JOIN DetalleVenta dr ON v.IdVenta = dr.IdVenta
                JOIN Libro l ON dr.IdLibro = l.IdLibro
                WHERE v.FechaVenta BETWEEN @desde AND @hasta
                GROUP BY l.Titulo;";
            return EjecutarDataTable(sql, desde, hasta);
        }

        public DataTable VentasPorVendedor(DateTime desde, DateTime hasta)
        {
            const string sql = @"
                SELECT e.Nombre + ' ' + e.Apellido AS Vendedor, COUNT(*) AS VentasRealizadas
                FROM Venta v
                JOIN Empleado e ON v.IdEmpleado = e.IdEmpleado
                WHERE v.FechaVenta BETWEEN @desde AND @hasta
                GROUP BY e.Nombre, e.Apellido;";
            return EjecutarDataTable(sql, desde, hasta);
        }

        private DataTable EjecutarDataTable(string sql, DateTime desde, DateTime hasta)
        {
            var dt = new DataTable();
            using (var conn = _conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                conn.Open();
                using (var da = new SqlDataAdapter(cmd))
                    da.Fill(dt);
            }
            return dt;
        }
    }
}
