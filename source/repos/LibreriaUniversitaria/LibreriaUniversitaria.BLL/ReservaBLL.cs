using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Lógica de negocio para la gestión de reservas.
    /// </summary>
    public class ReservaBLL
    {
        private readonly ReservaDAL reservaDAL;

        /// <summary>
        /// Constructor que inicializa el acceso a datos.
        /// </summary>
        public ReservaBLL()
        {
            reservaDAL = new ReservaDAL();
        }

        /// <summary>
        /// Cambia el estado de una reserva según su ID.
        /// </summary>
        /// <param name="idReserva">ID de la reserva a modificar</param>
        /// <param name="nuevoEstadoId">Nuevo estado (ej. 2 = Vendida, 3 = Cancelada, 4 = Vencida)</param>
        public void CambiarEstadoReserva(int idReserva, int nuevoEstadoId)
        {
            reservaDAL.ActualizarEstado(idReserva, nuevoEstadoId);
        }

        /// <summary>
        /// Marca automáticamente como vencidas las reservas que superan los 15 días sin confirmación.
        /// </summary>
        public void ActualizarReservasVencidas()
        {
            List<Reserva> reservas = reservaDAL.ObtenerPendientes();

            foreach (Reserva r in reservas)
            {
                TimeSpan diferencia = DateTime.Now - r.Fecha;
                if (diferencia.TotalDays > 15)
                {
                    CambiarEstadoReserva(r.IdReserva, 4); // 4 = Vencida
                    reservaDAL.RestaurarStockDeReserva(r.IdReserva);
                }
            }
        }

        /// <summary>
        /// Obtiene todas las reservas registradas.
        /// </summary>
        public List<Reserva> ObtenerTodas()
        {
            return reservaDAL.ObtenerTodas();
        }

        /// <summary>
        /// Inserta una nueva reserva en la base de datos.
        /// </summary>
        public void Insertar(Reserva reserva)
        {
            reservaDAL.Insertar(reserva);
        }
    }
}

