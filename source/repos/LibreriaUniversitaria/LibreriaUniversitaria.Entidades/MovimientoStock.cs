using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un movimiento que afecta el stock de un libro, como ingreso o egreso.
    /// </summary>
    public class MovimientoStock
    {
        public int IdMovimiento { get; set; }

        public DateTime Fecha { get; set; }

        public string TipoMovimiento { get; set; } // Ej: "Ingreso", "Egreso", "Reserva", etc.

        public int Cantidad { get; set; }

        public int IdLibro { get; set; }

        public int IdEmpleado { get; set; }

        // Propiedades de navegación 
        public Libro Libro { get; set; }
        public Empleado Empleado { get; set; }
    }
}

