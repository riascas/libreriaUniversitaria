using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa un ítem (libro) dentro de una reserva realizada por un cliente.
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
        /// Constructor vacío requerido por buenas prácticas y compatibilidad con formularios.
        /// </summary>
        public DetalleReserva() { }

        /// <summary>
        /// Constructor con parámetros. Inicializa el detalle validando datos esenciales.
        /// </summary>
        public DetalleReserva(int idDetalleReserva, Libro libro, int cantidad)
        {
            if (libro == null)
                throw new EntidadInvalidaException("El libro no puede ser nulo en un detalle de reserva.");
            if (cantidad <= 0)
                throw new EntidadInvalidaException("La cantidad debe ser mayor a cero.");

            _idDetalleReserva = idDetalleReserva;
            _libro = libro;
            _cantidad = cantidad;
        }

        /// <summary>
        /// Calcula el subtotal del ítem (precio del libro * cantidad).
        /// </summary>
        public override decimal Subtotal()
        {
            return _libro.Precio * _cantidad;
        }

        /// <summary>
        /// Representación de texto para mostrar en listas o grillas.
        /// </summary>
        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}

