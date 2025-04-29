using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using Persistencia;

namespace LogicaNegocio
{
    using LibreriaUniversitaria.Entidades;

    public class VentaService
    {
        // Crea una venta con detalles y calcula el total
        public Venta CrearVenta(Cliente cliente, List<DetalleVenta> detalles)
        {
            decimal total = detalles.Sum(d => d.Cantidad * d.PrecioUnitario);

            return new Venta
            {
                ClienteId = cliente.Id,
                Cliente = cliente,
                Detalles = detalles,
                FechaVenta = DateTime.Now,
                Total = total
            };
        }
    }
}

