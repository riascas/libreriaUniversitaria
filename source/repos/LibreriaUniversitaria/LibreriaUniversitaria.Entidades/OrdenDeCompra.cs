using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa una orden de compra emitida por la librería a una editorial.
    /// </summary>
    public class OrdenDeCompra
    {
        public int IdOrden { get; set; }
        public int IdEditorial { get; set; }
        public DateTime FechaOrden { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } // Ej: "Pendiente", "Confirmada", "Cancelada"

        // Constructor vacío (necesario para cargar desde la BD)
        public OrdenDeCompra() { }

        // Constructor para usar cuando creo una orden desde el formulario o BLL
        public OrdenDeCompra(int idEditorial, DateTime fechaOrden, decimal total, string estado)
        {
            IdEditorial = idEditorial;
            FechaOrden = fechaOrden;
            Total = total;
            Estado = estado;
        }

    }
}

