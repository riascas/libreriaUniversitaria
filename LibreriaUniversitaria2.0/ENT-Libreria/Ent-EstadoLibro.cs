using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class EstadoLibro
    {
        private string _descripcionEstadoLibro;


        public string DescripcionEstadoLibro
        {
            get { return _descripcionEstadoLibro; }
            set { _descripcionEstadoLibro = value; }
        }
    }
}
