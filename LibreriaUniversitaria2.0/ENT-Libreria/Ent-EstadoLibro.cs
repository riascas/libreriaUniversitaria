using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class EstadoLibro
    {
        private int _idEstadoLibro;
        private string _descripcionEstadoLibro;

        public int IdEstadoLibro
        {
            get { return _idEstadoLibro; }
            set { _idEstadoLibro = value; }
        }
        public string DescripcionEstadoLibro
        {
            get { return _descripcionEstadoLibro; }
            set { _descripcionEstadoLibro = value; }
        }
    }
}
