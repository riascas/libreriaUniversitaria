using System;
using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class VentaBLL
    {
        private readonly ReservaDAL _reservaDal = new ReservaDAL();
        private readonly LibroBLL _libroBll = new LibroBLL();

        public Reserva ValidarYObtenerReserva(int idReserva)
        {
            return _reservaDal.ObtenerPorId(idReserva);
        }

        public void ConfirmarVenta(Reserva r)
        {
            foreach (var det in r.Detalles)
            {
                // Le restamos stock al libro
                _libroBll.AjustarStock(det.IdLibro, -det.Cantidad);
            }
            // TODO: guardar Venta
        }
    }
}
