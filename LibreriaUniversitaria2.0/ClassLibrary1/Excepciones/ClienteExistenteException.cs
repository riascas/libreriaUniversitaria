using System;

namespace LibreriaUniversitaria.Entidades.Excepciones
{
    /// <summary>
    /// Excepción personalizada para indicar que el cliente ya existe.
    /// </summary>
    public class ClienteExistenteException : Exception
    {
        public ClienteExistenteException()
            : base("El cliente con ese documento ya está registrado.")
        {
        }

        public ClienteExistenteException(string mensaje)
            : base(mensaje)
        {
        }
    }
}
