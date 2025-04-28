using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    using Entidades;

    public class DescuentoService
    {
        public decimal AplicarDescuento(decimal precio, decimal porcentaje)
        {
            return precio - (precio * porcentaje / 100);
        }
    }
}
