using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;
using Persistencia;

namespace LogicaNegocio
{
    using LibreriaUniversitaria.Entidades;

    public class ReservaService
    {
        // Crea una reserva entre un cliente y un libro, registrando la fecha actual
        public Reserva CrearReserva(Cliente cliente, Libro libro)
        {
            return new Reserva
            {
                ClienteId = cliente.Id,
                Cliente = cliente,
                LibroId = libro.Id,
                Libro = libro,
                FechaReserva = DateTime.Now
            };
        }
    }
}
