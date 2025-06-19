using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class DAL_Libro
    {
		private string _isnb;

		public string ISNB
		{
			get { return _isnb; }
			set { _isnb = value; }
		}

		private string _titulo;

		public string Titulo
		{
			get { return _titulo; }
			set { _titulo = value; }
		}

		private string _autor;

		public string Autor
		{
			get { return _autor; }
			set { _autor = value; }
		}

		private decimal _precioLibro;

		public decimal PrecioLibro
        {
			get { return _precioLibro; }
			set { _precioLibro = value; }
		}

		private bool _disponible;

		public bool Disponible
		{
			get { return _disponible; }
			set { _disponible = value; }
		}

		private DAL_EstadoLibro _unEstadoLibro;

		public DAL_EstadoLibro UnEstadoLibro
		{
			get { return _unEstadoLibro; }
			set { _unEstadoLibro = value; }
		}

		private DAL_CategoriaLibro _unaCategoria;

		public DAL_CategoriaLibro UnaCategoria
		{
			get { return _unaCategoria; }
			set { _unaCategoria = value; }
		}

	}
}
