using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class BaseDetalle
    {
        private int _cantidad;
        private Libro _unLibro;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public Libro UnLibro
        {
            get { return _unLibro; }
            set { _unLibro = value; }
        }
        /// <summary>
        /// Metodo que calcula el subtotal de un detalle de venta.Se implementa en la clase que esta derivada.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public decimal CalcularSubTotal()
        {
            
            throw new NotImplementedException("se debe implementar en la clase derivada");
        }
    }
}
