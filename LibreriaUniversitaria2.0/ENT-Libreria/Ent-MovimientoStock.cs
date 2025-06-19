using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class MovimientoStock
    {
        private int _cantidadStock;
        private DateTime _fechaStock;

        public int CantidadStock
        {
            get { return _cantidadStock; }
            set { _cantidadStock = value; }
        }

        public DateTime FechaStock
        {
            get { return _fechaStock; }
            set { _fechaStock = value; }
        }
    }
}
