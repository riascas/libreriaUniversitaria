using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.BLL.Descuentos;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Lógica de negocio para la gestión de ventas.
    /// </summary>
    public class VentaBLL
    {
        private readonly VentaDAL ventaDAL;
        private readonly DetalleVentaDAL detalleDAL;
        private readonly ReservaBLL reservaBLL;
        private readonly IDescuento estrategiaDescuento;

        /// <summary>
        /// Constructor que inicializa las dependencias necesarias.
        /// </summary>
        public VentaBLL()
        {
            ventaDAL = new VentaDAL();
            detalleDAL = new DetalleVentaDAL();
            reservaBLL = new ReservaBLL();
            estrategiaDescuento = new DescuentoEstudiante();
        }

        /// <summary>
        /// Registra una nueva venta en el sistema a partir de una reserva.
        /// Aplica descuento si el cliente es estudiante.
        /// </summary>
        public void RegistrarVenta(Venta venta)
        {
            if (venta == null || venta.Reserva == null || venta.Cliente == null)
                throw new ArgumentException("Faltan datos para realizar la venta.");

            decimal totalSinDescuento = 0;

            foreach (var detalle in venta.Reserva.Detalles)
            {
                totalSinDescuento += detalle.Libro.Precio * detalle.Cantidad;
            }

            // Se calcula el total con la estrategia de descuento elegida
            decimal totalFinal = estrategiaDescuento.CalcularTotal(venta.Cliente, totalSinDescuento);

            venta.Total = totalFinal;
            venta.Fecha = DateTime.Now;

            // Guardo la venta principal
            int idVenta = ventaDAL.Insertar(venta);

            // Guardo cada detalle de la venta
            foreach (var detalle in venta.Reserva.Detalles)
            {
                detalleDAL.Insertar(new DetalleVenta
                {
                    IdVenta = idVenta,
                    IdLibro = detalle.IdLibro,
                    Cantidad = detalle.Cantidad,
                    PrecioUnitario = detalle.Libro.Precio
                });
            }

            // Cambio el estado de la reserva a "Vendida" (ID = 2)
            reservaBLL.CambiarEstadoReserva(venta.IdReserva, 2); // 2 = Vendida en la base
        }

        public Venta ObtenerPorId(int idVenta)
        {
            return ventaDAL.ObtenerPorId(idVenta);
        }
    }
}

