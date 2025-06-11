using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades

{
    // Clase que representa el estado de una reserva (Pendiente, Vendida, Vencida, Cancelada)
    public class EstadoReserva
    {
        // Atributos privados
        private int _idEstado;
        private string _nombre;

        // Propiedades publicas
        public int IdEstado
        {
            get { return _idEstado; }
            set { _idEstado = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Constructor vacio
        public EstadoReserva() { }

        // Constructor con parametros
        public EstadoReserva(int idEstado, string nombre)
        {
            _idEstado = idEstado;
            _nombre = nombre;
        }

        // Metodo ToString para mostrar el nombre del estado
        public override string ToString()
        {
            return Nombre;
        }
    }
}
