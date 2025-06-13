using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades.Excepciones;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa un domicilio de un cliente.
    /// Incluye calle, número y la localidad asociada.
    /// </summary>
    public class Domicilio
    {
        // Atributos privados
        private int _idDomicilio;
        private string _calle;
        private string _numero;
        private Localidad _localidad;

        // Propiedades públicas
        public int IdDomicilio
        {
            get { return _idDomicilio; }
            set { _idDomicilio = value; }
        }

        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        /// <summary>
        /// Relación con la clase Localidad, que incluye el código postal.
        /// </summary>
        public Localidad Localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        // Constructor vacío requerido
        public Domicilio() { }

        // Constructor con parámetros
        public Domicilio(int idDomicilio, string calle, string numero, Localidad localidad)
        {
            _idDomicilio = idDomicilio;
            _calle = calle;
            _numero = numero;
            _localidad = localidad;
        }

        // Método ToString para mostrar dirección completa
        public override string ToString()
        {
            return $"{Calle} {Numero}, {Localidad.Nombre} (CP: {Localidad.CodigoPostal})";
        }
    }
}
