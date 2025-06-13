using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa un ítem (libro) dentro de una venta.
    /// </summary>
    public class DetalleVenta : ADetalle
    {
        // Identificador único del detalle
        private int _idDetalleVenta;

        /// <summary>
        /// Precio del libro en el momento de la venta.
        /// </summary>
        public decimal PrecioUnitario { get; set; }

        /// <summary>
        /// Identificador único del detalle de venta.
        /// </summary>
        public int IdDetalleVenta
        {
            get { return _idDetalleVenta; }
            set { _idDetalleVenta = value; }
        }

        /// <summary>
        /// Constructor vacío requerido por formularios y herramientas de serialización.
        /// </summary>
        public DetalleVenta() { }

        /// <summary>
        /// Constructor con parámetros para inicializar el detalle con validaciones.
        /// </summary>
        public DetalleVenta(int idDetalleVenta, Libro libro, int cantidad, decimal precioUnitario)
        {
            if (libro == null)
                throw new EntidadInvalidaException("El libro no puede ser nulo en un detalle de venta.");
            if (cantidad <= 0)
                throw new EntidadInvalidaException("La cantidad debe ser mayor a cero.");
            if (precioUnitario < 0)
                throw new EntidadInvalidaException("El precio unitario no puede ser negativo.");

            _idDetalleVenta = idDetalleVenta;
            _libro = libro;
            _cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        /// <summary>
        /// Calcula el subtotal del ítem (precio unitario * cantidad).
        /// </summary>
        public override decimal Subtotal()
        {
            return PrecioUnitario * _cantidad;
        }

        /// <summary>
        /// Representación textual para mostrar en controles visuales.
        /// </summary>
        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}
