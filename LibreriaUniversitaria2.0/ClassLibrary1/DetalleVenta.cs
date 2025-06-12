using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un item (libro) dentro de una venta
    public class DetalleVenta : ADetalle
    {
        private int _idDetalleVenta;

        public int IdDetalleVenta
        {
            get { return _idDetalleVenta; }
            set { _idDetalleVenta = value; }
        }

        // Constructor vacio
        public DetalleVenta() { }

        // Constructor con parametros
        public DetalleVenta(int idDetalleVenta, Libro libro, int cantidad)
        {
            _idDetalleVenta = idDetalleVenta;
            _libro = libro;
            _cantidad = cantidad;
        }

        // Implementacion del metodo abstracto
        public override decimal Subtotal()
        {
            return _libro.Precio * _cantidad;
        }

        public override string ToString()
        {
            return $"{Libro.Titulo} x{Cantidad} - ${Subtotal():0.00}";
        }
    }
}
