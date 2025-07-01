using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa una venta realizada a partir de una reserva confirmada.
    /// </summary>
    public class Venta
    {
        // Identificador único de la venta
        public int IdVenta { get; set; }

        // Clave foránea al cliente que realizó la compra
        public int IdCliente { get; set; }

        // Clave foránea a la reserva asociada
        public int IdReserva { get; set; }

        // Fecha de la venta
        public DateTime Fecha { get; set; }

        // Monto total de la venta
        public decimal Total { get; set; }

        // Propiedad de navegación al cliente
        public Cliente Cliente { get; set; }

        // Propiedad de navegación a la reserva confirmada
        public Reserva Reserva { get; set; }

        // Lista de detalles de la venta (uno por cada libro vendido)
        public List<DetalleVenta> Detalles { get; set; }

        // Constructor por defecto
        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }

        // Constructor completo
        public Venta(int idVenta, int idCliente, int idReserva, DateTime fecha, decimal total, Cliente cliente, Reserva reserva)
        {
            IdVenta = idVenta;
            IdCliente = idCliente;
            IdReserva = idReserva;
            Fecha = fecha;
            Total = total;
            Cliente = cliente;
            Reserva = reserva;
            Detalles = new List<DetalleVenta>();
        }
    }
}

