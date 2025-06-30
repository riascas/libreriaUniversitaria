using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class EstadoReserva
    {
        private int _idEstadoReserva;
        private string _descripcionEstadoReserva;


        public int IdEstadoReserva
        {
            get { return _idEstadoReserva; }
            set { _idEstadoReserva = value; }
        }
        public string DescripcionEstadoReserva
        {
            get { return _descripcionEstadoReserva; }
            set { _descripcionEstadoReserva = value; }
        }
    }
}
