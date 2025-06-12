using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa una reserva de libros realizada por un cliente.
    /// </summary>
    public class Reserva
    {
        /// <summary>
        /// Identificador único de la reserva.
        /// </summary>
        public int IdReserva { get; set; }

        /// <summary>
        /// Fecha en la que se realizó la reserva.
        /// </summary>
        public DateTime FechaReserva { get; set; }

        /// <summary>
        /// Cliente que realizó la reserva.
        /// </summary>
        public Cliente Cliente { get; set; }

        /// <summary>
        /// Lista de ítems reservados (DetalleReserva).
        /// </summary>
        public List<DetalleReserva> Items { get; set; }

        /// <summary>
        /// Estado actual de la reserva (ej: Pendiente, Confirmada, Vencida).
        /// </summary>
        public EstadoReserva Estado { get; set; }

        /// <summary>
        /// Constructor por defecto que inicializa la lista de ítems y la fecha actual.
        /// </summary>
        public Reserva()
        {
            Items = new List<DetalleReserva>();
            FechaReserva = DateTime.Now;
        }

        /// <summary>
        /// Constructor con parámetros para inicializar una reserva.
        /// </summary>
        /// <param name="idReserva">ID de la reserva</param>
        /// <param name="fecha">Fecha de la reserva</param>
        /// <param name="cliente">Cliente que realizó la reserva</param>
        /// <param name="estado">Estado actual de la reserva</param>
        public Reserva(int idReserva, DateTime fecha, Cliente cliente, EstadoReserva estado)
        {
            IdReserva = idReserva;
            FechaReserva = fecha;
            Cliente = cliente;
            Estado = estado;
            Items = new List<DetalleReserva>();
        }

        /// <summary>
        /// Calcula el total de la reserva sumando los subtotales de cada ítem.
        /// </summary>
        /// <returns>Total en pesos</returns>
        public decimal Total()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }
    }
}
