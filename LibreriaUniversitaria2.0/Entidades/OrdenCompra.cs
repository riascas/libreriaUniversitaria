using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OrdenCompra
    {
        private int idCompra;
        private DateTime fechaCompra;
        private int cantidad;
        private decimal total;
        private string detalle;
        private string editorial;
        private string estado;

        public int IdCompra
        {
            get { return idCompra; }
            set { idCompra = value; }
        }

        public DateTime FechaCompra
        {
            get { return fechaCompra; }
            set { fechaCompra = value; }
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

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public void RealizarCompra()
        {

        }
    }
}
