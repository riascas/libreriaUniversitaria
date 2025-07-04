using ENT_Libreria;
using DAT_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class OrdenCompraService
    {
        private OrdenCompraDAO _ordenCompraRepo = new OrdenCompraDAO();
        private LibroDAO _libroRepo = new LibroDAO();
        private MovimientoStockDAO _stockRepo = new MovimientoStockDAO();

        public void RegistrarOrdenCompra(OrdenCompra orden, List<(Libro libro, int cantidad)> librosConCantidad)
        {
            orden.TotalCompra = librosConCantidad.Where(x => x.libro != null).Sum(x => x.libro.PrecioLibro * x.cantidad);
            orden.FechaCompra = DateTime.Now;
            orden.EstadoCompra = "Pendiente";

            _ordenCompraRepo.InsertarOrdenCompraCompleta(orden, librosConCantidad);
            
        }
    }
}
