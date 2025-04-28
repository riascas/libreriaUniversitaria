using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
