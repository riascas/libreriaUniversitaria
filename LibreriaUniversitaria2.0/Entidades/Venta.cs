using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Venta
    {
        private int idVenta;
        private DateTime fechaVenta;
        private int cantidad;
        private decimal total;

        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public DateTime FechaVenta
        {
            get { return fechaVenta; }
            set { fechaVenta = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public void RealizarVenta()
        {

        }

        public void CalcularAplicarDescuento()
        {

        }

        public decimal CalcularTotal()
        {
            return 0;
        }

        public void FinalizarVenta()
        {

        }


    }
}

