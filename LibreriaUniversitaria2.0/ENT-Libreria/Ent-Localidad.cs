using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Localidad

    {
        private int _idLocalidad;
        private string _nombreLocalidad;
        private Municipio _unMunicipio;

        public int IdLocalidad
        {
            get { return _idLocalidad; }
            set { _idLocalidad = value; }
        }

        public string NombreLocalidad
        {
            get { return _nombreLocalidad; }
            set { _nombreLocalidad = value; }
        }

        public Municipio UnMunicipio
        {
            get { return _unMunicipio; }
            set { _unMunicipio = value; }
        }
    }
}
