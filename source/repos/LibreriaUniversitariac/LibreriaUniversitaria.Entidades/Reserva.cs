using System;
using System.Collections.Generic;

namespace LibreriaUniversitaria.Entidades
{
    public enum EstadoReserva { Pendiente, Vendida, Vencida, Cancelada }

    public class DetalleReserva
    {
        public int IdReserva { get; set; }
        public int IdLibro { get; set; }
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public Cliente Cliente { get; set; }
        public EstadoReserva Estado { get; set; }
        public List<DetalleReserva> Detalles { get; set; } = new List<DetalleReserva>();
    }
}
