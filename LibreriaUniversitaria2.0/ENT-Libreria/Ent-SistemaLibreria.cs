using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class SistemaLibreria
    {
        private List<Cliente> _listaClientes;
        private List<Libro> _listaLibros;
        private List<Reserva> _listaReservas;
        private List<Empleado> _listaUsuarios;
        private List<Venta> _listaVentas;

        public List<Cliente> ListaClientes
        {
            get { return _listaClientes; }
            set { _listaClientes = value; }
        }

        public List<Libro> ListaLibros
        {
            get { return _listaLibros; }
            set { _listaLibros = value; }
        }

        public List<Reserva> ListaReservas
        {
            get { return _listaReservas; }
            set { _listaReservas = value; }
        }

        public List<Empleado> ListaUsuarios
        {
            get { return _listaUsuarios; }
            set { _listaUsuarios = value; }
        }

        public List<Venta> ListaVentas
        {
            get { return _listaVentas; }
            set { _listaVentas = value; }
        }
    }
}
