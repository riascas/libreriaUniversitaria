using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa el estado actual de una reserva (Pendiente, Vendida, Cancelada, Vencida).
    /// </summary>
    public class EstadoReserva
    {
        // Identificador único del estado
        public int IdEstadoReserva { get; set; }

        // Descripción textual del estado (ej. "Pendiente", "Vendida", etc.)
        public string Nombre { get; set; }

        // Constructor por defecto
        public EstadoReserva() { }

        // Constructor completo
        public EstadoReserva(int idEstadoReserva, string nombre)
        {
            IdEstadoReserva = idEstadoReserva;
            Nombre = nombre;
        }
    }
}

