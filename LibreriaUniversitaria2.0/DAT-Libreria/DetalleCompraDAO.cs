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
    public class DetalleCompraDAO
    {
        private Conexion conexion = new Conexion();

        public List<DetalleOrdenCompra> ObtenerTodos()
        {
            List<DetalleOrdenCompra> lista = new List<DetalleOrdenCompra>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM DetalleCompra");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new DetalleOrdenCompra
                {
                    IdDetalleCompra = Convert.ToInt32(fila["idDetalleCompra"]),
                    CantidadCompra = Convert.ToInt32(fila["CantidadCompra"]),
                    PrecioCosto = Convert.ToDecimal(fila["PrecioCosto"]),
                    UnaOrdendeCompra = new OrdenCompra
                    {
                        IdCompra = Convert.ToInt32(fila["idOrdenCompra"]),
                        TotalCompra = Convert.ToDecimal(fila["TotalCompra"]),
                        EstadoCompra = fila["EstadoCompra"].ToString(),
                        FechaCompra = Convert.ToDateTime(fila["FechaCompra"]),
                        UnaEditorial = new Editorial
                        {
                            IdEditorial = Convert.ToInt32(fila["idEditorial"]),
                            NombreEditorial = fila["NombreEditorial"].ToString()
                        },
                        UnEmpleado = new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(fila["idEmpleado"]),
                            Usuario = fila["Usuario"].ToString(),
                            Clave = fila["Clave"].ToString(),
                        }
                    },
                });
            }
            return lista;
        }
    }
}
