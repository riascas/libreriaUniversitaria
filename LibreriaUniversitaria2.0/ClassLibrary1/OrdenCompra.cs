using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa una orden de compra realizada a una editorial por un empleado.
    /// </summary>
    public class OrdenCompra
    {
        // Atributos privados
        private int _idOrdenCompra; // CAMBIADO de IdCompra a IdOrdenCompra
        private DateTime _fecha;
        private Editorial _editorial;
        private Empleado _empleado;
        private List<DetalleCompra> _items; // CAMBIADO de _detalles a _items

        // Propiedades públicas
        public int IdOrdenCompra
        {
            get { return _idOrdenCompra; }
            set { _idOrdenCompra = value; }
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

        public List<DetalleCompra> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        // Constructor vacío
        public OrdenCompra()
        {
            _items = new List<DetalleCompra>();
        }

        // Constructor con parámetros
        public OrdenCompra(int idOrdenCompra, DateTime fecha, Editorial editorial, Empleado empleado, List<DetalleCompra> items)
        {
            _idOrdenCompra = idOrdenCompra;
            _fecha = fecha;
            _editorial = editorial;
            _empleado = empleado;
            _items = items ?? new List<DetalleCompra>();
        }

        // Método para calcular el total de la orden
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Subtotal();
            }
            return total;
        }
    }
}

