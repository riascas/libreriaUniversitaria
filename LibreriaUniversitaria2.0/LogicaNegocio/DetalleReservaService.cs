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
    /// Servicio de negocio para manejar los detalles de las reservas (ítems reservados).
    /// </summary>
    public static class DetalleReservaService
    {
        /// <summary>
        /// Inserta un ítem en una reserva existente.
        /// </summary>
        /// <param name="detalle">El ítem con libro y cantidad</param>
        /// <param name="idReserva">ID de la reserva a la que pertenece</param>
        public static void AgregarDetalleAReserva(DetalleReserva detalle, int idReserva)
        {
            if (detalle == null || detalle.Libro == null || detalle.Cantidad <= 0)
                throw new ArgumentException("El detalle de reserva no es válido.");

            DetalleReservaRepository.Insertar(detalle, idReserva);
        }

        /// <summary>
        /// Obtiene todos los ítems (libros) de una reserva determinada.
        /// </summary>
        /// <param name="idReserva">ID de la reserva</param>
        /// <returns>Lista de DetalleReserva</returns>
        public static List<DetalleReserva> ObtenerDetallesPorReserva(int idReserva)
        {
            if (idReserva <= 0)
                throw new ArgumentException("ID de reserva inválido.");

            return DetalleReservaRepository.ObtenerPorReserva(idReserva);
        }

        /// <summary>
        /// Calcula el total de una reserva sumando los subtotales de cada ítem.
        /// </summary>
        /// <param name="detalles">Lista de ítems de la reserva</param>
        /// <returns>Total acumulado</returns>
        public static decimal CalcularTotal(List<DetalleReserva> detalles)
        {
            decimal total = 0;

            foreach (var item in detalles)
            {
                total += item.Subtotal();
            }

            return total;
        }
    }
}

