using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un item (libro) dentro de una venta
    public class DetalleVenta : ADetalle
    {
        private int _idDetalleVenta;

        /// <summary>
        /// Identificador único del detalle de venta.
        /// </summary>
        public int IdDetalleVenta
        {
            get { return _idDetalleVenta; }
            set { _idDetalleVenta = value; }
        }

        /// <summary>
        /// Precio que tenía el libro en el momento de la venta.
        /// </summary>
        public decimal PrecioUnitario { get; set; }

        // Constructor vacío
        public DetalleVenta() { }

        // Constructor con todos los parámetros
        public DetalleVenta(int idDetalleVenta, Libro libro, int cantidad, decimal precioUnitario)
        {
            _idDetalleVenta = idDetalleVenta;
            _libro = libro;
            _cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        // Implementación del método Subtotal (precio * cantidad)
        public override decimal Subtotal()
        {
            return PrecioUnitario * _cantidad;
        }

        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}
