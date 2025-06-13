using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa un ítem dentro de una orden de compra.
    /// Incluye el libro, la cantidad y el precio unitario acordado.
    /// </summary>
    public class DetalleCompra : ADetalle
    {
        // Identificador del detalle de compra
        public int IdDetalleCompra { get; set; }

        // Precio acordado por unidad al momento de la compra
        public decimal PrecioUnitario { get; set; }

        /// <summary>
        /// Constructor vacío requerido por buenas prácticas.
        /// </summary>
        public DetalleCompra() { }

        /// <summary>
        /// Constructor con parámetros para inicializar el detalle.
        /// </summary>
        public DetalleCompra(int idDetalleCompra, Libro libro, int cantidad, decimal precioUnitario)
        {
            IdDetalleCompra = idDetalleCompra;
            Libro = libro;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
        }

        /// <summary>
        /// Calcula el subtotal del ítem (cantidad * precio unitario).
        /// </summary>
        public override decimal Subtotal()
        {
            return Cantidad * PrecioUnitario;
        }

        /// <summary>
        /// Devuelve una descripción del ítem para mostrar en listas o reportes.
        /// </summary>
        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}
