using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un cliente que realiza reservas y compras.
    /// </summary>
    public class Cliente
    {
        // Atributos privados
        private int _idCliente;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _numeroDocumento;
        private bool _esEstudiante;

        // Propiedades públicas
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }

        public bool EsEstudiante
        {
            get { return _esEstudiante; }
            set { _esEstudiante = value; }
        }

        // Constructor vacío obligatorio
        public Cliente() { }

        // Constructor completo
        public Cliente(int idCliente, string nombre, string apellido, string email, string numeroDocumento, bool esEstudiante)
        {
            _idCliente = idCliente;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _numeroDocumento = numeroDocumento;
            _esEstudiante = esEstudiante;
        }

        // Método para mostrar el nombre completo
        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        // Para mostrar en combos o grillas
        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {NumeroDocumento}";
        }

        /// <summary>
        /// Valida que el cliente tenga datos esenciales completos.
        /// </summary>
        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new EntidadInvalidaException("El nombre del cliente no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(Apellido))
                throw new EntidadInvalidaException("El apellido del cliente no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(NumeroDocumento) || NumeroDocumento.Length != 8)
                throw new EntidadInvalidaException("El número de documento debe tener 8 dígitos.");

            if (string.IsNullOrWhiteSpace(Email))
                throw new EntidadInvalidaException("El email del cliente no puede estar vacío.");
        }
    }
}
