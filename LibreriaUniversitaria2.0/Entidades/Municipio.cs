using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un municipio (region o departamento)
    public class Municipio
    {
        // Atributos privados
        private int _idMunicipio;
        private string _nombre;

        // Propiedades publicas
        public int IdMunicipio
        {
            get { return _idMunicipio; }
            set { _idMunicipio = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Constructor vacio
        public Municipio() { }

        // Constructor con parametros
        public Municipio(int idMunicipio, string nombre)
        {
            _idMunicipio = idMunicipio;
            _nombre = nombre;
        }

        // Metodo ToString para mostrar el nombre del municipio
        public override string ToString()
        {
            return Nombre;
        }
    }
}
