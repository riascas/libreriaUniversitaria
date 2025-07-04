using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un rol dentro del sistema (por ejemplo: Administrador, Vendedor, etc.).
    /// </summary>
    public class Rol
    {
        // Identificador único del rol
        public int IdRol { get; set; }

        // Nombre del rol (ej. "Administrador", "Vendedor", "Bibliotecario", etc.)
        public string Nombre { get; set; }

        // Constructor por defecto
        public Rol() { }

        // Constructor completo
        public Rol(int idRol, string nombre)
        {
            IdRol = idRol;
            Nombre = nombre;
        }
    }
}

