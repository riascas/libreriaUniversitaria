using System;
using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class ReservaBLL
    {
        private readonly ReservaDAL _dal = new ReservaDAL();

        /// <summary>Todos los registros de reserva/venta.</summary>
        public List<Reserva> ObtenerTodos()
            => _dal.ObtenerTodos();

        /// <summary>Reserva individual por Id.</summary>
        public Reserva ObtenerPorId(int id)
            => _dal.ObtenerPorId(id);

        /// <summary>Crea reserva con detalles.</summary>
        public int InsertarReserva(Reserva r)
        {
            if (r == null) throw new ArgumentNullException(nameof(r));
            return _dal.InsertarConDetalles(r);
        }

        /// <summary>Cambia sólo el estado.</summary>
        public void CambiarEstado(int idReserva, EstadoReserva nuevoEstado)
            => _dal.ActualizarEstado(idReserva, nuevoEstado);
    }
}
