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

    public class ReporteService
    {
        // Devuelve la cantidad total de ejemplares vendidos sumando todos los detalles
        public int CalcularCantidadVendida(List<DetalleVenta> detalles)
        {
            return detalles.Sum(d => d.Cantidad);
        }
    }
}