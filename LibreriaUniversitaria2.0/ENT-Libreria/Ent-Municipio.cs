using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Municipio
    {
        private int _idMunicipio;
        private string _nombreMunicipio;


        public int IdMunicipio
        {
            get { return _idMunicipio; }
            set { _idMunicipio = value; }
        }
        public string NombreMunicipio
        {
            get { return _nombreMunicipio; }
            set { _nombreMunicipio = value; }
        }
    }
}
