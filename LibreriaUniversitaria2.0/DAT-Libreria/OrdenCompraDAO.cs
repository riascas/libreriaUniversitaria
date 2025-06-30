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
    public class OrdenCompraDAO
    {
        private Conexion conexion = new Conexion();

        public List<OrdenCompra> ObtenerTodos()
        {
            List<OrdenCompra> lista = new List<OrdenCompra>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM OrdenCompra");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new OrdenCompra
                {
                    IdCompra = Convert.ToInt32(fila["idCompra"]),
                    FechaCompra = Convert.ToDateTime(fila["FechaCompra"]),
                    TotalCompra = Convert.ToDecimal(fila["TotalCompra"]),
                    EstadoCompra = fila["EstadoCompra"].ToString(),
                    UnaEditorial = new Editorial
                    {
                        IdEditorial = Convert.ToInt32(fila["FK_Editorial"]),
                        NombreEditorial = fila["NombreEditorial"].ToString()
                    },
                    UnEmpleado = new Empleado
                    {
                        IdEmpleado = Convert.ToInt32(fila["idEmpleado"]),
                        Usuario = fila["Usuario"].ToString(),
                        Clave = fila["Clave"].ToString()
                    }
                });
            }
            return lista;
        }
    }
}
