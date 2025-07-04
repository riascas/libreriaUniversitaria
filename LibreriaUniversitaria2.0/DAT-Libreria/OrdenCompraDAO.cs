using DAL;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Libreria
{
    public class OrdenCompraDAO
    {
        private Conexion conexion = new Conexion();
        private LibroDAO libroDAO = new LibroDAO();

        public void InsertarOrdenCompraCompleta(OrdenCompra orden, List<(Libro libro, int cantidad)> librosConCantidad)
        {
            try
            {
                
                string queryOrden = $"INSERT INTO OrdenCompra (FechaCompra, TotalCompra, EstadoCompra, FK_Empleado, FK_Editorial) " +
                                    $"VALUES ('{orden.FechaCompra:yyyy-MM-dd HH:mm:ss}', {orden.TotalCompra}, '{orden.EstadoCompra}', {orden.UnEmpleado.IdEmpleado}, {orden.UnaEditorial.IdEditorial})";

                conexion.EscribirPorComando(queryOrden);
                orden.IdCompra = ObtenerUltimoId("OrdenCompra");

                foreach (var (libro, cantidad) in librosConCantidad)
                {
                    if (libro == null)
                        throw new Exception("Se detectó un libro nulo en la lista de compra.");

                    int idLibro = libro.IdLibro;

                    
                    if (idLibro == 0)
                    {
                        idLibro = libroDAO.Insertar(libro);
                        libro.IdLibro = idLibro;
                    }

                    if (idLibro == 0)
                        throw new Exception("El idLibro sigue siendo 0 luego de la inserción. Verifica la tabla Libro.");

                    
                    string queryDetalle = $"INSERT INTO DetalleOrdenCompra (CantidadCompra, PrecioCosto, FK_OrdenCompra) " +
                                          $"VALUES ({cantidad}, {libro.PrecioLibro}, {orden.IdCompra})";
                    conexion.EscribirPorComando(queryDetalle);
                    int idDetalle = ObtenerUltimoId("DetalleOrdenCompra");

                    
                    string queryStock = $"INSERT INTO MovimientoStock (FechaStock, CantidadStock, FK_DetalleOrdenCompra, FK_Libro) " +
                                        $"VALUES ('{DateTime.Now:yyyy-MM-dd HH:mm:ss}', {cantidad}, {idDetalle}, {idLibro})";
                    conexion.EscribirPorComando(queryStock);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la orden de compra: " + ex.Message);
            }
        }

        private int ObtenerUltimoId(string tabla)
        {
            DataTable tablaID = conexion.LeerPorComando($"SELECT IDENT_CURRENT('{tabla}') AS UltimoID");
            return Convert.ToInt32(tablaID.Rows[0]["UltimoID"]);
        }
    }

}
