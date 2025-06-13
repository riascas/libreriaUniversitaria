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
    /// Clase que representa una venta realizada a partir de una reserva confirmada.
    /// </summary>
    public class Venta
    {
        /// <summary>
        /// Identificador unico de la venta.
        /// </summary>
        public int IdVenta { get; set; }

        /// <summary>
        /// Fecha en que se realizo la venta.
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Empleado que realizo la venta.
        /// </summary>
        public Empleado Empleado { get; set; }

        /// <summary>
        /// Reserva asociada a esta venta (reserva concretada).
        /// </summary>
        public Reserva Reserva { get; set; }

        /// <summary>
        /// Total abonado por el cliente, incluyendo posibles descuentos.
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// Constructor vacio obligatorio para crear instancias vacias.
        /// </summary>
        public Venta() { }

        /// <summary>
        /// Constructor completo de venta.
        /// </summary>
        public Venta(int idVenta, DateTime fecha, Empleado empleado, Reserva reserva, decimal total)
        {
            IdVenta = idVenta;
            Fecha = fecha;
            Empleado = empleado;
            Reserva = reserva;
            Total = total;
        }

        /// <summary>
        /// Valida que la venta tenga todos los datos obligatorios.
        /// Lanza una excepción si hay datos inválidos.
        /// </summary>
        public void Validar()
        {
            if (Empleado == null)
                throw new EntidadInvalidaException("La venta debe tener un empleado asignado.");

            if (Reserva == null)
                throw new EntidadInvalidaException("La venta debe estar asociada a una reserva.");

            if (Fecha == DateTime.MinValue)
                throw new EntidadInvalidaException("La venta debe tener una fecha válida.");

            if (Total <= 0)
                throw new EntidadInvalidaException("El total de la venta debe ser mayor a cero.");
        }
    }
}

