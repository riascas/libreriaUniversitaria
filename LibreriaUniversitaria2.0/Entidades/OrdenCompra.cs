using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa una orden de compra realizada a una editorial
    public class OrdenCompra
    {
        // Atributos privados
        private int _idCompra;
        private DateTime _fecha;
        private Editorial _editorial;
        private Empleado _empleado;
        private List<DetalleCompra> _detalles;

        // Propiedades publicas
        public int IdCompra
        {
            get { return _idCompra; }
            set { _idCompra = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Editorial Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public List<DetalleCompra> Detalles
        {
            get { return _detalles; }
            set { _detalles = value; }
        }

        // Constructor vacio
        public OrdenCompra()
        {
            _detalles = new List<DetalleCompra>();
        }

        // Constructor con parametros
        public OrdenCompra(int idCompra, DateTime fecha, Editorial editorial, Empleado empleado, List<DetalleCompra> detalles)
        {
            _idCompra = idCompra;
            _fecha = fecha;
            _editorial = editorial;
            _empleado = empleado;
            _detalles = detalles ?? new List<DetalleCompra>();
        }

        // Metodo para calcular el total de la orden
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
