using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    using Entidades;

    public class ReporteService
    {
        public int CalcularCantidadVendida(List<DetalleVenta> ventas)
        {
            return ventas.Sum(d => d.Cantidad);
        }
    }
}