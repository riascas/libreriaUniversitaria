using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa una venta realizada a un cliente
    public class Venta
    {
        // Atributos privados
        private int _idVenta;
        private DateTime _fecha;
        private Cliente _cliente;
        private Empleado _empleado;
        private List<DetalleVenta> _detalles;

        // Propiedades publicas
        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
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

        public List<DetalleVenta> Detalles
        {
            get { return _detalles; }
            set { _detalles = value; }
        }

        // Constructor vacio
        public Venta()
        {
            _detalles = new List<DetalleVenta>();
        }

        // Constructor con parametros
        public Venta(int idVenta, DateTime fecha, Cliente cliente, Empleado empleado, List<DetalleVenta> detalles)
        {
            _idVenta = idVenta;
            _fecha = fecha;
            _cliente = cliente;
            _empleado = empleado;
            _detalles = detalles ?? new List<DetalleVenta>();
        }

        // Metodo para calcular el total de la venta
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

