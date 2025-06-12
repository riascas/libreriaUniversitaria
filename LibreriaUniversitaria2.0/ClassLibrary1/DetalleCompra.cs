using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un item dentro de una orden de compra (libro y cantidad)
    public class DetalleCompra : ADetalle
    {
        private int _idDetalleCompra;

        public int IdDetalleCompra
        {
            get { return _idDetalleCompra; }
            set { _idDetalleCompra = value; }
        }

        // Constructor vacio
        public DetalleCompra() { }

        // Constructor con parametros
        public DetalleCompra(int idDetalleCompra, Libro libro, int cantidad)
        {
            _idDetalleCompra = idDetalleCompra;
            _libro = libro;
            _cantidad = cantidad;
        }

        // Implementacion del metodo abstracto
        public override decimal Subtotal()
        {
            return _libro.Precio * _cantidad;
        }

        // Metodo ToString para mostrar la descripcion del item
        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}
