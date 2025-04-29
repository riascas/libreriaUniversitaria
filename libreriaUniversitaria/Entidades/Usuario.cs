using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }             // Identificador del usuario
        public string NombreUsuario { get; set; }  // Nombre de usuario para login
        public string Clave { get; set; }          // Contraseña (ideal: encriptada)
        public Rol Rol { get; set; }               // Perfil del usuario (enum)

        // Constructor con parámetros para facilitar creación
        public Usuario(int id, string nombre, string clave, Rol rol)
        {
            Id = id;
            NombreUsuario = nombre;
            Clave = clave;
            Rol = rol;
        }

        // Constructor vacío para ORM o uso básico
        public Usuario()
        {
            NombreUsuario = string.Empty;
            Clave = string.Empty;
        }
    }
}

