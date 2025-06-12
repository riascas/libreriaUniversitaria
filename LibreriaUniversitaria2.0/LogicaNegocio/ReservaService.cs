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
    /// Servicio para la gestión de reservas.
    /// </summary>
    public static class ReservaService
    {
        /// <summary>
        /// Obtiene todas las reservas registradas.
        /// </summary>
        public static List<Reserva> ObtenerTodas()
        {
            return ReservaRepository.ObtenerTodas();
        }

        /// <summary>
        /// Registra una nueva reserva.
        /// </summary>
        public static void RegistrarReserva(Reserva reserva)
        {
            ReservaRepository.Insertar(reserva);
        }

        /// <summary>
        /// Busca una reserva por su ID.
        /// </summary>
        public static Reserva BuscarPorId(int idReserva)
        {
            var todas = ReservaRepository.ObtenerTodas();
            return todas.Find(r => r.IdReserva == idReserva);
        }

        /// <summary>
        /// Obtiene todas las reservas de un cliente específico.
        /// </summary>
        public static List<Reserva> ObtenerPorCliente(int idCliente)
        {
            var todas = ReservaRepository.ObtenerTodas();
            return todas.FindAll(r => r.Cliente.IdCliente == idCliente);
        }
    }
}
