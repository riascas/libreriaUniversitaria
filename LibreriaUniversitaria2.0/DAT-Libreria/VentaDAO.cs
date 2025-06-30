using DAL;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Libreria
{
    public class VentaDAO
    {
        private Conexion conexion = new Conexion();

        public List<Venta> ObtenerTodos()
        {
            List<Venta> lista = new List<Venta>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Venta");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Venta
                {
                    IdVenta = Convert.ToInt32(fila["idVenta"]),
                    FechaVenta = Convert.ToDateTime(fila["FechaVenta"]),
                    TotalVenta = Convert.ToDecimal(fila["TotalVenta"]),
                    UnEmpleado = new Empleado
                    {
                        IdEmpleado = Convert.ToInt32(fila["IdEmpleado"]),
                        Usuario = fila["Usuario"].ToString(),
                        Clave = fila["Clave"].ToString(),
                    },
                    UnCliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(fila["IdCliente"]),
                        EsEstudiante = Convert.ToBoolean(fila["EsEstudiante"]),
                    }
                });
            }
            return lista;
        }

        public int Insertar(Venta venta)
        {
            string query = $"INSERT INTO Venta (FechaVenta, TotalVenta, UnEmpleado, UnCliente) VALUES ('{venta.FechaVenta:yyyy-MM-dd}', {venta.TotalVenta}, {venta.UnEmpleado}, {venta.UnCliente})";
            return conexion.EscribirPorComando(query);
        }
    }
}
