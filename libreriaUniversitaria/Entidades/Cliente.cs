using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Cliente
    {
        public int Id { get; set; } // Identificador único
        public string Nombre { get; set; } // Nombre del cliente
        public string Email { get; set; } // Correo electrónico
        public string Direccion { get; set; } // Dirección aunque debe haber otra clase para localidad
        public bool EsEstudiante { get; set; } // ¿Es estudiante?

        // Constructor vacío
        public Cliente()
        {
            Nombre = string.Empty;
            Email = string.Empty;
        }
    }
}
