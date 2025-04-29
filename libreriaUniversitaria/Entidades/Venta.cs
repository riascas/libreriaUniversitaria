using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Venta
    {
        public int Id { get; set; }                     // ID de la venta
        public int ClienteId { get; set; }              // FK al cliente que compra
        public Cliente Cliente { get; set; }                 // Navegación EF

        public List<DetalleVenta> Detalles { get; set; }     // Relación uno a muchos
        public decimal Total { get; set; }                   // Total (puede calcularse)
        public DateTime FechaVenta { get; set; }        // Fecha de la venta

        // Constructor vacío inicializa lista para evitar nulls
        public Venta()
        {
            Detalles = new List<DetalleVenta>();
        }
    }
}

