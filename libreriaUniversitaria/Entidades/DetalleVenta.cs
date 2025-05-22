using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class DetalleVenta
    {
        private decimal precioProducto;
        private int idDetallevta;
        private int cantidad;

        public decimal PrecioProducto
        {
            get { return precioProducto; }
            set { precioProducto = value; }
        }

        public int IdDetallevta
        {
            get { return idDetallevta; }
            set { idDetallevta = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal CalcularSubtotal()
        {
            return 0;
        }

        public void ImprimirFC()
        {

        }

        public void AlertaStock()
        {

        }       
    }
}

