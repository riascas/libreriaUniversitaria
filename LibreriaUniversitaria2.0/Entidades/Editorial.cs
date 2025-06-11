using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa una editorial de libros
    public class Editorial
    {
        // Atributos privados
        private int _idEditorial;
        private string _nombre;

        // Propiedades publicas
        public int IdEditorial
        {
            get { return _idEditorial; }
            set { _idEditorial = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Constructor vacio
        public Editorial() { }

        // Constructor con parametros
        public Editorial(int idEditorial, string nombre)
        {
            _idEditorial = idEditorial;
            _nombre = nombre;
        }

        // Metodo ToString para mostrar el nombre de la editorial en comboBox o listas
        public override string ToString()
        {
            return Nombre;
        }
    }
}
