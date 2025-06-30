using DAL;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Libreria
{
    public class ReservaDAO
    {
        private Conexion conexion = new Conexion();

        public List<Reserva> ObtenerTodos()
        {
            List<Reserva> lista = new List<Reserva>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Reserva");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Reserva
                {
                    IdReserva = Convert.ToInt32(fila["idReserva"]),
                    FechaReserva = Convert.ToDateTime(fila["FechaReserva"]),
                    FechaRetiro = Convert.ToDateTime(fila["FechaRetiro"]),
                    UnCliente = new Cliente
                    {
                        IdCliente = Convert.ToInt32(fila["idCliente"])
                    },
                    UnEmpleado = new Empleado
                    {
                        IdEmpleado = Convert.ToInt32(fila["idEmpleado"])
                    },
                    UnEstadoReserva = new EstadoReserva
                    {
                        IdEstadoReserva = Convert.ToInt32(fila["idEstadoReserva"])
                    }
                });
            }
            return lista;
        }

        public int Insertar(Reserva reserva)
        {
            string query = $"INSERT INTO Reserva (FechaReserva, FechaRetiro, idEmpleado, idCliente, idEstadoReserva) " +
                           $"VALUES ('{reserva.FechaReserva:yyyy-MM-dd}', '{reserva.FechaRetiro:yyyy-MM-dd}', {reserva.UnEmpleado}, {reserva.UnCliente}, {reserva.UnEstadoReserva})";
            return conexion.EscribirPorComando(query);
        }
    }
}
