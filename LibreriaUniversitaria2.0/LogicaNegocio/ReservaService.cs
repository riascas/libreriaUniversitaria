using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.Datos;

namespace LibreriaUniversitaria.LogicaNegocio
{
    /// <summary>
    /// Clase de lógica de negocio para gestionar reservas.
    /// </summary>
    public static class ReservaService
    {
        /// <summary>
        /// Obtiene todas las reservas del sistema, incluyendo cliente y estado.
        /// </summary>
        public static List<Reserva> ObtenerTodas()
        {
            return ReservaRepository.ObtenerTodas();
        }

        /// <summary>
        /// Inserta una nueva reserva con estado "Pendiente".
        /// </summary>
        /// <param name="reserva">Objeto reserva a insertar.</param>
        public static void RegistrarReserva(Reserva reserva)
        {
            // Validaciones básicas antes de insertar
            if (reserva == null)
                throw new ArgumentNullException("La reserva no puede ser nula.");
            if (reserva.Cliente == null || reserva.Cliente.IdCliente <= 0)
                throw new ArgumentException("La reserva debe tener un cliente válido.");

            // Asignar estado inicial "Pendiente"
            EstadoReserva estadoPendiente = EstadoReservaService.ObtenerPorId(1); // ID 1: Pendiente
            reserva.Estado = estadoPendiente;

            reserva.FechaReserva = DateTime.Now;

            // Insertar en la base de datos
            ReservaRepository.Insertar(reserva);
        }

        /// <summary>
        /// Filtra las reservas por estado.
        /// </summary>
        public static List<Reserva> ObtenerPorEstado(int idEstadoReserva)
        {
            List<Reserva> todas = ReservaRepository.ObtenerTodas();
            return todas.FindAll(r => r.Estado.IdEstadoReserva == idEstadoReserva);
        }

        /// <summary>
        /// Filtra las reservas por cliente.
        /// </summary>
        public static List<Reserva> ObtenerPorCliente(int idCliente)
        {
            List<Reserva> todas = ReservaRepository.ObtenerTodas();
            return todas.FindAll(r => r.Cliente.IdCliente == idCliente);
        }
    }
}
