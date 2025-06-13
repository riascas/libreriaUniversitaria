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
    /// Clase de lógica de negocio para manejar los estados de reserva.
    /// </summary>
    public static class EstadoReservaService
    {
        /// <summary>
        /// Devuelve todos los estados posibles que puede tener una reserva.
        /// </summary>
        public static List<EstadoReserva> ObtenerTodos()
        {
            return EstadoReservaRepository.ObtenerTodos();
        }

        /// <summary>
        /// Devuelve un estado de reserva por su identificador.
        /// </summary>
        /// <param name="idEstado">ID del estado a buscar.</param>
        public static EstadoReserva ObtenerPorId(int idEstado)
        {
            if (idEstado <= 0)
                throw new ArgumentException("El ID del estado debe ser mayor que cero.");

            // Simplificación con operador ?? (si querés hacerlo más claro, podés dejarlo con if)
            return EstadoReservaRepository.ObtenerPorId(idEstado)
                   ?? throw new Exception("No se encontró un estado de reserva con ese ID.");
        }
    }
}

