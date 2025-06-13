using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaUniversitaria.Entidades.Excepciones;
using System;
using System.Collections.Generic;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa una orden de compra realizada a una editorial por un empleado.
    /// </summary>
    public class OrdenCompra
    {
        // Atributos privados
        private int _idOrdenCompra;
        private DateTime _fecha;
        private Editorial _editorial;
        private Empleado _empleado;
        private List<DetalleCompra> _items;

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
            _fecha = DateTime.Now;
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

        /// <summary>
        /// Calcula el total sumando los subtotales de los ítems.
        /// </summary>
        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Subtotal();
            }
            return total;
        }

        /// <summary>
        /// Valida que los datos de la orden estén completos.
        /// </summary>
        public void Validar()
        {
            if (_editorial == null)
                throw new EntidadInvalidaException("La orden debe tener una editorial asignada.");

            if (_empleado == null)
                throw new EntidadInvalidaException("La orden debe tener un empleado responsable.");

            if (_items == null || _items.Count == 0)
                throw new EntidadInvalidaException("La orden debe incluir al menos un ítem.");

            _editorial.Validar();
            _empleado.Validar();
        }
    }
}


