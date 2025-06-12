using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa un ítem (libro) dentro de una reserva.
    /// </summary>
    public class DetalleReserva : ADetalle
    {
        // Campo privado para el ID
        private int _idDetalleReserva;

        /// <summary>
        /// Identificador único del detalle de reserva.
        /// </summary>
        public int IdDetalleReserva
        {
            get { return _idDetalleReserva; }
            set { _idDetalleReserva = value; }
        }

        /// <summary>
        /// Constructor vacío.
        /// </summary>
        public DetalleReserva() { }

        /// <summary>
        /// Constructor con parámetros.
        /// </summary>
        public DetalleReserva(int idDetalleReserva, Libro libro, int cantidad)
        {
            _idDetalleReserva = idDetalleReserva;
            _libro = libro;
            _cantidad = cantidad;
        }

        /// <summary>
        /// Implementación del método abstracto que calcula el subtotal.
        /// </summary>
        public override decimal Subtotal()
        {
            return _libro.Precio * _cantidad;
        }

        /// <summary>
        /// Representación de texto para mostrar en listas u otros controles.
        /// </summary>
        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}

