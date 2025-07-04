using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Localidad

    {
        private string _codigoPostal;
        private Municipio _unMunicipio;

        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }

        public Municipio UnMunicipio
        {
            get { return _unMunicipio; }
            set { _unMunicipio = value; }
        }
    }
}
