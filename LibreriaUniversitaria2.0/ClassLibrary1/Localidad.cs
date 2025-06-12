using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa una localidad geográfica (ciudad, pueblo, etc.)
    public class Localidad
    {
        // Atributos privados
        private int _idLocalidad;
        private string _nombre;
        private Municipio _municipio;

        // Propiedades publicas
        public int IdLocalidad
        {
            get { return _idLocalidad; }
            set { _idLocalidad = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Municipio Municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        // Constructor vacio
        public Localidad() { }

        // Constructor con parametros
        public Localidad(int idLocalidad, string nombre, Municipio municipio)
        {
            _idLocalidad = idLocalidad;
            _nombre = nombre;
            _municipio = municipio;
        }

        // Metodo ToString para mostrar el nombre de la localidad
        public override string ToString()
        {
            return Nombre;
        }
    }
}
