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

        /// <summary>
        /// Alias que facilita el acceso al identificador de Cliente (IdCliente).
        /// </summary>
        public int Id
        {
            get => IdCliente;
            set => IdCliente = value;
        }

        // Indica si el cliente es estudiante
        public bool EsEstudiante { get; set; }

        // Constructor por defecto
        public Cliente() { }

        // Constructor completo
        public Cliente(int idCliente, int idPersona, string nombre, string apellido, int dni, string email, Domicilio domicilio, bool esEstudiante)
            : base(idPersona, nombre, apellido, dni, email, domicilio)
        {
            IdCliente = idCliente;
            EsEstudiante = esEstudiante;
        }
    }
}
