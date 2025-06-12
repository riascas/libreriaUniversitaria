using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa a un empleado del sistema
    public class Empleado : APersona
    {
        private int _idEmpleado;
        private string _usuario;
        private string _contrasena;
        private Rol _rol;

        public int IdEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        public Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

        // Constructor vacio
        public Empleado() { }

        // Constructor con parametros
        public Empleado(int idEmpleado, string usuario, string contrasena, string nombre, string apellido, string email, Rol rol)
        {
            _idEmpleado = idEmpleado;
            _usuario = usuario;
            _contrasena = contrasena;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _rol = rol;
        }

        // Metodo ToString para mostrar el nombre completo
        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
