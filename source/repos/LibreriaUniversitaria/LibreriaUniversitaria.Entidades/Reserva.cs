using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa una reserva realizada por un cliente.
    /// </summary>
    public class Reserva
    {
        // Identificador único de la reserva
        public int IdReserva { get; set; }

        // Clave foránea al cliente que realizó la reserva
        public int IdCliente { get; set; }

        // Clave foránea al estado actual de la reserva
        public int IdEstadoReserva { get; set; }

        // Fecha de creación de la reserva
        public DateTime Fecha { get; set; }

        // Propiedad de navegación para acceder al Cliente
        public Cliente Cliente { get; set; }

        // Propiedad de navegación al estado textual (Pendiente, Vendida, etc.)
        public EstadoReserva Estado { get; set; }

        // Lista de detalles asociados a la reserva (uno por cada libro reservado)
        public List<DetalleReserva> Detalles { get; set; }

        // Constructor por defecto
        public Reserva()
        {
            Detalles = new List<DetalleReserva>();
        }

        // Constructor completo
        public Reserva(int idReserva, int idCliente, int idEstadoReserva, DateTime fecha, Cliente cliente, EstadoReserva estado)
        {
            IdReserva = idReserva;
            IdCliente = idCliente;
            IdEstadoReserva = idEstadoReserva;
            Fecha = fecha;
            Cliente = cliente;
            Estado = estado;
            Detalles = new List<DetalleReserva>();
        }
    }
}

