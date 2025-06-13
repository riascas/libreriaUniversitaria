using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase que representa una localidad geográfica (ciudad, pueblo, etc.)
    /// que pertenece a un municipio y tiene un código postal único.
    /// </summary>
    public class Localidad
    {
        // Atributos privados
        private int _idLocalidad;
        private string _nombre;
        private string _codigoPostal;
        private Municipio _municipio;

        // Propiedad que representa el identificador único de la localidad
        public int IdLocalidad
        {
            get { return _idLocalidad; }
            set { _idLocalidad = value; }
        }

        // Nombre de la localidad (por ejemplo: González Catán, Ezeiza)
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Código postal correspondiente a esta localidad
        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }

        // Relación con el municipio al que pertenece
        public Municipio Municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        /// <summary>
        /// Permite acceder al Id del municipio desde la entidad.
        /// </summary>
        public int IdMunicipio
        {
            get { return _municipio != null ? _municipio.IdMunicipio : 0; }
            set
            {
                if (_municipio == null)
                    _municipio = new Municipio();
                _municipio.IdMunicipio = value;
            }
        }

        // Constructor vacío
        public Localidad() { }

        // Constructor con parámetros
        public Localidad(int idLocalidad, string nombre, string codigoPostal, Municipio municipio)
        {
            _idLocalidad = idLocalidad;
            _nombre = nombre;
            _codigoPostal = codigoPostal;
            _municipio = municipio;
        }

        // Representación textual (útil para ComboBox, listas, etc.)
        public override string ToString()
        {
            return $"{Nombre} (CP: {CodigoPostal})";
        }
    }
}

