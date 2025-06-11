using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa a un cliente de la libreria
    public class Cliente : APersona
    {
        private int _idCliente;
        private string _tipoDocumento;
        private string _numeroDocumento;
        private bool _esEstudiante;
        private Domicilio _domicilio;
        private Localidad _localidad;

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public string TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
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

        public Domicilio Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public Localidad Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        // Constructor vacio
        public Cliente() { }

        // Constructor con parametros
        public Cliente(int idCliente, string tipoDoc, string numeroDoc, string nombre, string apellido, string email, bool esEstudiante, Domicilio domicilio, Localidad localidad)
        {
            _idCliente = idCliente;
            _tipoDocumento = tipoDoc;
            _numeroDocumento = numeroDoc;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _esEstudiante = esEstudiante;
            _domicilio = domicilio;
            _localidad = localidad;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}

