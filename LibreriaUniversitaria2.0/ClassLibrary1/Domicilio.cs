using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un domicilio (direccion) de un cliente
    public class Domicilio
    {
        // Atributos privados
        private int _idDomicilio;
        private string _calle;
        private string _numero;
        private string _codigoPostal;

        // Propiedades publicas
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

        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }

        // Constructor vacio
        public Domicilio() { }

        // Constructor con parametros
        public Domicilio(int idDomicilio, string calle, string numero, string codigoPostal)
        {
            _idDomicilio = idDomicilio;
            _calle = calle;
            _numero = numero;
            _codigoPostal = codigoPostal;
        }

        // Metodo ToString para mostrar la direccion formateada
        public override string ToString()
        {
            return $"{Calle} {Numero} (CP: {CodigoPostal})";
        }
    }
}
