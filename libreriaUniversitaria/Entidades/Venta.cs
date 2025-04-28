using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades

{
    public class Venta
    {
        public int Id { get; set; } // ID de la venta
        public int ClienteId { get; set; } // ID del cliente que compra
        public List<Libro> LibrosVendidos { get; set; } // Lista de libros vendidos
        public decimal Total { get; set; } // Total de la venta
        public DateTime FechaVenta { get; set; } // Fecha de la venta

        // Constructor vacío
        public Venta()
        {
            Cliente = new Cliente();
            Libro = new Libro();
            FechaVenta = DateTime.Now;
        }
    }
}
