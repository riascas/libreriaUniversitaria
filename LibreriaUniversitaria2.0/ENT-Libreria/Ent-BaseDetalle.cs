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

        public decimal CalcularSubTotal()
        {
            throw new NotImplementedException("Debe implementarse en la clase derivada");

        }
    }
}
