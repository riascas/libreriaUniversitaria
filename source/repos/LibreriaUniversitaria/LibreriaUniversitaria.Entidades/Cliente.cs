using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un cliente del sistema, que hereda de Persona.
    /// </summary>
    public class Cliente : APersona
    {
        public int IdCliente { get; set; }

        // Constructor por defecto
        public Cliente() { }

        // Constructor completo
        public Cliente(int idCliente, int idPersona, string nombre, string apellido, string dni, string email, Domicilio domicilio)
            : base(idPersona, nombre, apellido, dni, email, domicilio)
        {
            IdCliente = idCliente;
        }
    }
}



