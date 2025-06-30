using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Libro
    {
        private int _idLibro;
        private string _autor;
        private bool _disponible;
        private string _isbn;
        private decimal _precioLibro;
        private string _titulo;
        private CategoriaLibro _unaCategoriaLibro;
        private EstadoLibro _unEstadoLibro;


        public int IdLibro
        {
            get { return _idLibro; }
            set { _idLibro = value; }
        }
        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public bool Disponible
        {
            get { return _disponible; }
            set { _disponible = value; }
        }

        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public decimal PrecioLibro
        {
            get { return _precioLibro; }
            set { _precioLibro = value; }
        }

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public CategoriaLibro UnaCategoriaLibro
        {
            get { return _unaCategoriaLibro; }
            set { _unaCategoriaLibro = value; }
        }

        public EstadoLibro UnEstadoLibro
        {
            get { return _unEstadoLibro; }
            set { _unEstadoLibro = value; }
        }

        public bool CalculaDisponibilidad()
        {
            return Disponible;
        }
    }
}
