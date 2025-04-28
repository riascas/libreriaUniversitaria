using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    using Entidades;
    using LibreriaUniversitaria.Entidades;

    public class ReservaService
    {
        public Reserva CrearReserva(Cliente cliente, Libro libro)
        {
            return new Reserva
            {
                Cliente = cliente,
                Libro = libro,
                FechaReserva = DateTime.Now
            };
        }
    }
}
