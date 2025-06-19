using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class EstadoReserva
    {
        private string _descripcionEstadoReserva;

        public string DescripcionEstadoReserva
        {
            get { return _descripcionEstadoReserva; }
            set { _descripcionEstadoReserva = value; }
        }
    }
}
