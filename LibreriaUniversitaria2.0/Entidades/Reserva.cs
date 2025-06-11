using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa una reserva de libros realizada por un cliente
    public class Reserva
    {
        // Atributos privados
        private int _idReserva;
        private DateTime _fecha;
        private Cliente _cliente;
        private Empleado _empleado;
        private EstadoReserva _estado;
        private List<DetalleReserva> _detalles;

        // Propiedades publicas
        public int IdReserva
        {
            get { return _idReserva; }
            set { _idReserva = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public EstadoReserva Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public List<DetalleReserva> Detalles
        {
            get { return _detalles; }
            set { _detalles = value; }
        }

        // Constructor vacio
        public Reserva()
        {
            _detalles = new List<DetalleReserva>();
        }

        // Constructor con parametros
        public Reserva(int idReserva, DateTime fecha, Cliente cliente, Empleado empleado, EstadoReserva estado, List<DetalleReserva> detalles)
        {
            _idReserva = idReserva;
            _fecha = fecha;
            _cliente = cliente;
            _empleado = empleado;
            _estado = estado;
            _detalles = detalles ?? new List<DetalleReserva>();
        }

        // Metodo para calcular el total de la reserva
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var detalle in _detalles)
            {
                total += detalle.Subtotal();
            }
            return total;
        }
    }
}
