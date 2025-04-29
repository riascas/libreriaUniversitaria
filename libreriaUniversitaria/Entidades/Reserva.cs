using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaUniversitaria.Entidades
{
    public class Reserva
    {
        public int Id { get; set; }                          // ID de la reserva

        public int ClienteId { get; set; }                   // Clave foránea
        public Cliente Cliente { get; set; }                 // Navegación EF

        public int LibroId { get; set; }                     // Clave foránea
        public Libro Libro { get; set; }                     // Navegación EF

        public DateTime FechaReserva { get; set; }           // Fecha en que se reservó
    }
}



