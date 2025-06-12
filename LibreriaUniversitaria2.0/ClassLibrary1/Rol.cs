using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un rol de usuario en el sistema (Administrador, Vendedor, etc.)
    public class Rol
    {
        // Atributos privados
        private int _idRol;
        private string _nombre;

        // Propiedades publicas
        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        // Constructor vacio (requerido por frameworks y formularios)
        public Rol() { }

        // Constructor con parametros
        public Rol(int idRol, string nombre)
        {
            _idRol = idRol;
            _nombre = nombre;
        }

        // Metodo ToString para mostrar el nombre del rol en comboBox o grillas
        public override string ToString()
        {
            return Nombre;
        }
    }
}
