using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class OrdenCompra
    {
        private DateTime _fechaCompra;
        private Editorial _unaEditorial;
        private List<DetalleVenta> _detalleVenta;

        public DateTime FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }

        public Editorial UnaEditorial
        {
            get { return _unaEditorial; }
            set { _unaEditorial = value; }
        }

        public List<DetalleVenta> DetalleVenta
        {
            get { return _detalleVenta; }
            set { _detalleVenta = value; }
        }

        /// <summary>
        /// Metodo que calcula el total de una orden de compra.
        /// </summary>
        /// <returns></returns>
        public decimal CalcularTotal()
        {
            decimal total = 0;

            if (_detalleVenta != null)
            {
                foreach (var detalle in _detalleVenta)
                {
                    total += detalle.CalcularSubTotal();
                }
            }

            return total;
        }
    }
}
