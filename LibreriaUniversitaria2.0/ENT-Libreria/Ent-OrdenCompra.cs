using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class OrdenCompra
    {
        private int _idCompra;
        private decimal _totalCompra;
        private string _estadoCompra;
        private DateTime _fechaCompra;
        private Editorial _unaEditorial;
        private Empleado _unEmpleado;

        public int IdCompra
        {
            get { return _idCompra; }
            set { _idCompra = value; }
        }
        public decimal TotalCompra
        {
            get { return _totalCompra; }
            set { _totalCompra = value; }
        }

        public string EstadoCompra
        {
            get { return _estadoCompra; }
            set { _estadoCompra = value; }
        }
        public DateTime FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }

        public Editorial UnaEditorial
        {
            get { return _unaEditorial; }
            set { _unaEditorial = value; }
        }
        public Empleado UnEmpleado
        {
            get { return _unEmpleado; }
            set { _unEmpleado = value; }
        }

        /* me falta  hacer este metodo
        private decimal DetalleVenta;
        
        public decimal detalleventa
        {
            get { return DetalleVenta; }
            set { DetalleVenta = value; }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var detalle in DetalleVenta)
            {
                total += detalle.CalcularSubTotal();
            }

            return total;
        }
        */
    }
}
