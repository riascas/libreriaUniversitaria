using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Domicilio
    {
        private int idDomicilio;
        private string calle;
        private string localidad;
        private string partido;
        private int altura;
        private string provincia;
        private string pais;

        public int IdDomicilio
        {
            get { return idDomicilio; }
            set { idDomicilio = value; }
        }

        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Partido
        {
            get { return partido; }
            set { partido = value; }
        }

        public int Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public string Provincia
        {
            get { return provincia; }
            set { provincia = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public void CargarDomicilio()
        {

        }

    }
}
