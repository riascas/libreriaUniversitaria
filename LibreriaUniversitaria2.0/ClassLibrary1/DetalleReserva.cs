using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un item (libro) dentro de una reserva
    public class DetalleReserva : ADetalle
    {
        private int _idDetalleReserva;

        public int IdDetalleReserva
        {
            get { return _idDetalleReserva; }
            set { _idDetalleReserva = value; }
        }

        // Constructor vacio
        public DetalleReserva() { }

        // Constructor con parametros
        public DetalleReserva(int idDetalleReserva, Libro libro, int cantidad)
        {
            _idDetalleReserva = idDetalleReserva;
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
