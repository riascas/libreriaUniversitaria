using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un detalle de una reserva, indicando un libro y su cantidad.
    /// </summary>
    public class DetalleReserva
    {
        // Identificador único del detalle
        public int IdDetalleReserva { get; set; }

        // Clave foránea a la reserva principal
        public int IdReserva { get; set; }

        // Clave foránea al libro reservado
        public int IdLibro { get; set; }

        // Cantidad de ejemplares reservados
        public int Cantidad { get; set; }

        // Propiedad de navegación al libro reservado
        public Libro Libro { get; set; }

        // Constructor por defecto
        public DetalleReserva() { }

        // Constructor completo
        public DetalleReserva(int idDetalleReserva, int idReserva, int idLibro, int cantidad, Libro libro)
        {
            IdDetalleReserva = idDetalleReserva;
            IdReserva = idReserva;
            IdLibro = idLibro;
            Cantidad = cantidad;
            Libro = libro;
        }
    }
}

