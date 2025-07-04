using System;
using System.Collections.Generic;

namespace LibreriaUniversitaria.Entidades
{
    public class OrdenCompra
    {
        public int IdOrden { get; set; }
        public Proveedor Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public List<DetalleOrdenCompra> Detalles { get; set; }
    }

    public class DetalleOrdenCompra
    {
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}