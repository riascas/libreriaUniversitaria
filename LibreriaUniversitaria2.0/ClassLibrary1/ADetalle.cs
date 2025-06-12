using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase abstracta que representa un item generico de detalle
    public abstract class ADetalle
    {
        protected Libro _libro;
        protected int _cantidad;

        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        // Metodo abstracto que cada subclase debe implementar
        public abstract decimal Subtotal();
    }
}
