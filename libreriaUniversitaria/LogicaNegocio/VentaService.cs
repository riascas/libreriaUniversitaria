using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicaNegocio
{
    using Entidades;
    using LibreriaUniversitaria.Entidades;

    public class VentaService
    {
        public Venta CrearVenta(Cliente cliente, List<DetalleVenta> detalles)
        {
            decimal total = detalles.Sum(d => d.Subtotal);
            return new Venta
            {
                Cliente = cliente,
                Detalles = detalles,
                Fecha = DateTime.Now,
                Total = total
            };
        }
    }
}
