using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class Domicilio
    {
        private int _altura;
        private string _calle;
        private Localidad _unaLocalidad;

        public int Altura
        {
            get { return _altura; }
            set { _altura = value; }
        }

        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public Localidad UnaLocalidad
        {
            get { return _unaLocalidad; }
            set { _unaLocalidad = value; }
        }
    }
}
