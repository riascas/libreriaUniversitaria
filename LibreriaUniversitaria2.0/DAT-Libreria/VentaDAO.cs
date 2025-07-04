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

        public int Insertar(Venta venta)
        {
            string query = $"INSERT INTO Venta (FechaVenta, TotalVenta, FK_Empleado, FK_Cliente) VALUES ('{venta.FechaVenta:yyyy-MM-dd HH:mm:ss}', {venta.TotalVenta}, {venta.UnEmpleado.IdEmpleado}, {venta.UnCliente.IdCliente})";
            conexion.EscribirPorComando(query);
            DataTable tablaID = conexion.LeerPorComando("SELECT IDENT_CURRENT('Venta') AS UltimoID");
            return Convert.ToInt32(tablaID.Rows[0]["UltimoID"]);
        }
    }
}
