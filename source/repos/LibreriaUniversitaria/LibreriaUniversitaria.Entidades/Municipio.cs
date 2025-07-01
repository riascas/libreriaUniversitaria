using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un municipio dentro del sistema, utilizado para la organización geográfica.
    /// </summary>
    public class Municipio
    {
        public int IdMunicipio { get; set; }     // Identificador único del municipio
        public string Nombre { get; set; }       // Nombre del municipio

        // Constructor por defecto
        public Municipio() { }

        // Constructor completo
        public Municipio(int idMunicipio, string nombre)
        {
            IdMunicipio = idMunicipio;
            Nombre = nombre;
        }
    }
}

