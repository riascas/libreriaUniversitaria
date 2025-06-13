using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa un libro disponible en la librería.
    /// </summary>
    public class Libro
    {
        // Atributos privados
        private int _idLibro;
        private string _isbn;
        private string _titulo;
        private string _autor;
        private decimal _precio;
        private int _stock;
        private Editorial _editorial;

        // Propiedades públicas
        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }

        /// <summary>
        /// ISBN (código único internacional del libro).
        /// Ejemplo: 978-3-16-148410-0
        /// </summary>
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
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

        /// <summary>
        /// Permite acceder al Id de la editorial asociada al libro.
        /// Esta propiedad es útil para la carga o lectura desde la base de datos.
        /// </summary>
        public int IdEditorial
        {
            get { return _editorial != null ? _editorial.IdEditorial : 0; }
            set
            {
                if (_editorial == null)
                    _editorial = new Editorial();
                _editorial.IdEditorial = value;
            }
        }

        // Constructor vacío
        public Libro() { }

        // Constructor con parámetros
        public Libro(int idLibro, string isbn, string titulo, string autor, decimal precio, int stock, Editorial editorial)
        {
            _idLibro = idLibro;
            _isbn = isbn;
            _titulo = titulo;
            _autor = autor;
            _precio = precio;
            _stock = stock;
            _editorial = editorial;
        }

        // Método ToString para mostrar título y autor
        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }
    }
}

