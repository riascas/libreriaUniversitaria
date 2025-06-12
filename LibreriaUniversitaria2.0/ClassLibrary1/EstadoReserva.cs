using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa el estado actual de una reserva (Pendiente, Vendida, Vencida, Cancelada).
    /// </summary>
    public class EstadoReserva
    {
        // Campo privado para el ID del estado
        private int _idEstadoReserva;

        // Campo privado para el nombre del estado
        private string _nombre;

        /// <summary>
        /// Identificador único del estado.
        /// </summary>
        public int IdEstadoReserva
        {
            get { return _idEstadoReserva; }
            set { _idEstadoReserva = value; }
        }

        /// <summary>
        /// Nombre descriptivo del estado (por ejemplo: Pendiente, Confirmada).
        /// </summary>
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Constructor vacío requerido por buenas prácticas y herramientas de serialización.
        /// </summary>
        public EstadoReserva() { }

        /// <summary>
        /// Constructor con parámetros para inicializar un estado de reserva.
        /// </summary>
        /// <param name="idEstadoReserva">ID del estado</param>
        /// <param name="nombre">Nombre del estado</param>
        public EstadoReserva(int idEstadoReserva, string nombre)
        {
            _idEstadoReserva = idEstadoReserva;
            _nombre = nombre;
        }

        /// <summary>
        /// Representación textual del objeto, útil para listas desplegables.
        /// </summary>
        /// <returns>Nombre del estado</returns>
        public override string ToString()
        {
            return Nombre;
        }
    }
}
