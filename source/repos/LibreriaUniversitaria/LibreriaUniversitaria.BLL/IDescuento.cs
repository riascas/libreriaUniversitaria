using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL.Descuentos
{
    /// <summary>
    /// Interfaz para aplicar una estrategia de descuento.
    /// </summary>
    public interface IDescuento
    {
        decimal CalcularTotal(Cliente cliente, decimal subtotal);
    }
}


