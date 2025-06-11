using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.Datos
{
    // Clase que simula una base de datos para la entidad Reserva
    public static class ReservaRepository
    {
        // Lista estatica para guardar reservas
        private static List<Reserva> _reservas = new List<Reserva>();

        // Metodo para obtener todas las reservas
        public static List<Reserva> ObtenerTodas()
        {
            return _reservas;
        }

        // Metodo para guardar una nueva reserva
        public static void Guardar(Reserva reserva)
        {
            _reservas.Add(reserva);
        }

        // Metodo para buscar por ID
        public static Reserva ObtenerPorId(int id)
        {
            return _reservas.FirstOrDefault(r => r.IdReserva == id);
        }

        // Metodo para buscar reservas por cliente
        public static List<Reserva> ObtenerPorCliente(Cliente cliente)
        {
            return _reservas
                .Where(r => r.Cliente.NumeroDocumento == cliente.NumeroDocumento &&
                            r.Cliente.TipoDocumento == cliente.TipoDocumento)
                .ToList();
        }

        // Metodo para actualizar el estado de una reserva
        public static void ActualizarEstado(int idReserva, EstadoReserva nuevoEstado)
        {
            var reserva = ObtenerPorId(idReserva);
            if (reserva != null)
            {
                reserva.Estado = nuevoEstado;
            }
        }

        // Metodo para eliminar una reserva
        public static void Eliminar(int idReserva)
        {
            var reserva = ObtenerPorId(idReserva);
            if (reserva != null)
            {
                _reservas.Remove(reserva);
            }
        }
    }
}
