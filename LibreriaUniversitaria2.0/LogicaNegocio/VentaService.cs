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
    /// Clase que representa la lógica de negocio relacionada a las ventas.
    /// </summary>
    public static class VentaService
    {
        /// <summary>
        /// Registra una venta a partir de una reserva confirmada.
        /// Cambia el estado de la reserva a "Vendida".
        /// </summary>
        /// <param name="venta">Objeto venta que contiene la reserva asociada, el empleado y la fecha.</param>
        public static void RegistrarVenta(Venta venta)
        {
            // Validar que la venta tenga una reserva asociada
            if (venta.Reserva == null)
                throw new Exception("La venta debe tener una reserva asociada.");

            // Validar que la reserva esté en estado pendiente
            if (venta.Reserva.Estado == null || venta.Reserva.Estado.Nombre != "Pendiente")
                throw new Exception("Solo se pueden registrar ventas a partir de reservas pendientes.");

            // Validar que la reserva tenga ítems
            if (venta.Reserva.Detalles == null || venta.Reserva.Detalles.Count == 0)
                throw new Exception("La reserva no tiene libros para vender.");

            // Calcular total de la venta desde los ítems de la reserva
            decimal total = 0;
            foreach (var item in venta.Reserva.Detalles)
            {
                total += item.Subtotal();
            }
            venta.Total = total;

            // Registrar la venta en base de datos
            VentaRepository.RegistrarVenta(venta);
        }

        /// <summary>
        /// Devuelve todas las ventas registradas en el sistema.
        /// </summary>
        /// <returns>Lista de ventas</returns>
        public static List<Venta> ObtenerTodas()
        {
            return VentaRepository.ObtenerTodas();
        }
    }
}
