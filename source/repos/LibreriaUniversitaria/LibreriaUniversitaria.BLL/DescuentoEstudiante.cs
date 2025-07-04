using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL.Descuentos
{
    /// <summary>
    /// Aplica un 10% de descuento si el cliente es estudiante.
    /// </summary>
    public class DescuentoEstudiante : IDescuento
    {
        public decimal CalcularTotal(Cliente cliente, decimal subtotal)
        {
            if (cliente != null && cliente.EsEstudiante)
                return subtotal * 0.90m;

            return subtotal;
        }
    }
}
