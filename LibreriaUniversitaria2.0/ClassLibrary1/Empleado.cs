using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades.Excepciones;


namespace LibreriaUniversitaria.Entidades
{
    public class Empleado
    {
        private int _idEmpleado;
        private string _nombre;
        private string _apellido;
        private string _dni;  // usamos esto para login
        private string _clave;
        private Rol _rol;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
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

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        public Empleado() { }

        public Empleado(int idEmpleado, string nombre, string apellido, string dni, string clave, Rol rol)
        {
            _idEmpleado = idEmpleado;
            _nombre = nombre;
            _apellido = apellido;
            _dni = dni;
            _clave = clave;
            _rol = rol;
        }

        public string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public override string ToString()
        {
            return $"{NombreCompleto()} - {DNI}";
        }

        public void Validar()
        {
            if (string.IsNullOrWhiteSpace(Nombre))
                throw new EntidadInvalidaException("El nombre del empleado no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(Apellido))
                throw new EntidadInvalidaException("El apellido del empleado no puede estar vacío.");

            if (string.IsNullOrWhiteSpace(DNI) || DNI.Length != 8)
                throw new EntidadInvalidaException("El DNI del empleado debe tener 8 dígitos.");

            if (string.IsNullOrWhiteSpace(Clave))
                throw new EntidadInvalidaException("La clave no puede estar vacía.");

            if (Rol == null)
                throw new EntidadInvalidaException("El empleado debe tener un rol asignado.");
        }
    }
}
