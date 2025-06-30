using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Venta
    {
        private int _idVenta;
        private List<DetalleVenta> _detalleVentas;
        private DateTime _fechaVenta;
        private decimal _totalVenta;
        private Empleado _unEmpleado;
        private Cliente _unCliente;

        public int IdVenta
        {
            get { return _idVenta; }
            set { _idVenta = value; }
        }
        public List<DetalleVenta> DetalleVentas
        {
            get { return _detalleVentas; }
            set { _detalleVentas = value; }
        }

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
            set { _fechaVenta = value; }
        }

        public decimal TotalVenta
        {
            get { return _totalVenta; }
            set { _totalVenta = value; }
        }

        public Empleado UnEmpleado
        {
            get { return _unEmpleado; }
            set { _unEmpleado = value; }
        }

        public Cliente UnCliente
        {
            get { return _unCliente; }
            set { _unCliente = value; }
        }

        public float AplicarDescuento()
        {
            decimal total = CalcularTotal();

            if (total > 1000)
                return 0.10f; // 10% de descuento

            return 0; // Sin descuento

        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var detalle in DetalleVentas)
            {
                total += detalle.CalcularSubTotal();
            }

            return total;
        }
    }
}
