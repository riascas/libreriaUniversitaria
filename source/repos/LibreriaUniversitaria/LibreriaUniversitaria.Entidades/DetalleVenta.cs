using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un detalle de una venta, indicando el libro vendido, cantidad y precio unitario.
    /// </summary>
    public class DetalleVenta
    {
        // Identificador único del detalle de venta
        public int IdDetalleVenta { get; set; }

        // Clave foránea a la venta principal
        public int IdVenta { get; set; }

        // Clave foránea al libro vendido
        public int IdLibro { get; set; }

        // Cantidad de ejemplares vendidos
        public int Cantidad { get; set; }

        // Precio unitario del libro en el momento de la venta
        public decimal PrecioUnitario { get; set; }

        // Propiedad de navegación al libro
        public Libro Libro { get; set; }

        // Constructor por defecto
        public DetalleVenta() { }

        // Constructor completo
        public DetalleVenta(int idDetalleVenta, int idVenta, int idLibro, int cantidad, decimal precioUnitario, Libro libro)
        {
            IdDetalleVenta = idDetalleVenta;
            IdVenta = idVenta;
            IdLibro = idLibro;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Libro = libro;
        }
    }
}
