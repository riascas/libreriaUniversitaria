using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaUniversitaria.Entidades
{
    public class Libro
    {
        private int idLibro;
        private string titulo;
        private int stock;
        private decimal precio;
        private string autor;

        public int IdLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public void CargarLibro()
        {

        }

        public void Reservar()
        {

        }

        public void ModificarStock()
        {

        }         // Navegación EF

    }
}



