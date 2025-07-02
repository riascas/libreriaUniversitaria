using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un ítem (libro) incluido en una orden de compra.
    /// </summary>
    public class DetalleOrdenDeCompra
    {
        public int IdDetalle { get; set; }
        public int IdOrden { get; set; }
        public int IdLibro { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        // Constructor vacío (necesario para cargar desde la BD)
        public DetalleOrdenDeCompra() { }

        // Constructor para usar cuando agrego ítems desde el formulario o la lógica
        public DetalleOrdenDeCompra(int idOrden, int idLibro, int cantidad, decimal precioUnitario)
        {
            IdOrden = idOrden;
            IdLibro = idLibro;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;


        }
    }
}
