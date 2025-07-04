using System;
using System.Collections.Generic;
using System.Linq;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Provee datos para los distintos reportes de reservas/ventas.
    /// </summary>
    public class ReporteBLL
    {
        private readonly ReservaBLL _resBLL = new ReservaBLL();

        /// <summary>
        /// Ventas por vendedor en un rango de fechas.
        /// </summary>
        public List<Reserva> VentasPorVendedor(DateTime desde, DateTime hasta)
        {
            return _resBLL.ObtenerTodos()
                          .Where(r => r.Estado == EstadoReserva.Vendida
                                   && r.FechaReserva.Date >= desde.Date
                                   && r.FechaReserva.Date <= hasta.Date)
                          .ToList();
        }

        /// <summary>
        /// Ventas por cliente en un rango de fechas.
        /// </summary>
        public List<Reserva> VentasPorCliente(DateTime desde, DateTime hasta)
        {
            return _resBLL.ObtenerTodos()
                          .Where(r => r.Estado == EstadoReserva.Vendida
                                   && r.FechaReserva.Date >= desde.Date
                                   && r.FechaReserva.Date <= hasta.Date)
                          .ToList();
        }

        /// <summary>
        /// Detalle de ventas por libro en un rango de fechas.
        /// </summary>
        public List<DetalleReserva> VentasPorLibro(DateTime desde, DateTime hasta)
        {
            return _resBLL.ObtenerTodos()
                          .Where(r => r.Estado == EstadoReserva.Vendida
                                   && r.FechaReserva.Date >= desde.Date
                                   && r.FechaReserva.Date <= hasta.Date)
                          .SelectMany(r => r.Detalles)
                          .ToList();
        }

        /// <summary>
        /// Permite filtrar reservas por estado y rango de fechas.
        /// </summary>
        public List<Reserva> ReservasPorEstado(EstadoReserva estado, DateTime desde, DateTime hasta)
        {
            return _resBLL.ObtenerTodos()
                          .Where(r => r.Estado == estado
                                   && r.FechaReserva.Date >= desde.Date
                                   && r.FechaReserva.Date <= hasta.Date)
                          .ToList();
        }
    }
}
