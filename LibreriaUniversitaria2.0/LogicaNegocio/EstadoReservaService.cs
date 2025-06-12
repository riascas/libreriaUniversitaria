using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using LibreriaUniversitaria.Datos;

namespace LibreriaUniversitaria.LogicaNegocio
{
    /// <summary>
    /// Clase que contiene la lógica de negocio relacionada con los estados de reserva.
    /// </summary>
    public static class EstadoReservaService
    {
        /// <summary>
        /// Devuelve la lista completa de estados posibles para una reserva.
        /// </summary>
        /// <returns>Lista de objetos EstadoReserva</returns>
        public static List<EstadoReserva> ObtenerTodos()
        {
            return EstadoReservaRepository.ObtenerTodos();
        }

        /// <summary>
        /// Devuelve un estado de reserva a partir de su identificador.
        /// </summary>
        /// <param name="id">ID del estado</param>
        /// <returns>Objeto EstadoReserva correspondiente al ID</returns>
        public static EstadoReserva ObtenerPorId(int id)
        {
            return EstadoReservaRepository.ObtenerPorId(id);
        }
    }
}

