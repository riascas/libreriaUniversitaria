using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class DetalleVenta
    {
        public int Id { get; set; }                          // ID del detalle
        public int VentaId { get; set; }                     // Clave foránea a Venta
        public Venta Venta { get; set; }                     // Navegación EF

        public int LibroId { get; set; }                     // Clave foránea a Libro
        public Libro Libro { get; set; }                     // Navegación EF

        public int Cantidad { get; set; }                    // Cantidad de ejemplares
        public decimal PrecioUnitario { get; set; }          // Precio en el momento de la venta
    }
}

