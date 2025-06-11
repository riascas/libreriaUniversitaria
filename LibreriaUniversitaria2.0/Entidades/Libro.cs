using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un libro disponible en la libreria
    public class Libro
    {
        // Atributos privados
        private int _idLibro;
        private string _titulo;
        private string _autor;
        private decimal _precio;
        private int _stock;
        private Editorial _editorial;

        // Propiedades publicas
        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public Editorial Editorial
        {
            get { return _editorial; }
            set { _editorial = value; }
        }

        // Constructor vacio
        public Libro() { }

        // Constructor con parametros
        public Libro(int idLibro, string titulo, string autor, decimal precio, int stock, Editorial editorial)
        {
            _idLibro = idLibro;
            _titulo = titulo;
            _autor = autor;
            _precio = precio;
            _stock = stock;
            _editorial = editorial;
        }

        // Metodo ToString para mostrar titulo y autor
        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }
    }
}
