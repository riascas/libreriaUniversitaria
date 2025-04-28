using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Rol Perfil { get; set; }

        public Usuario(int id, string nombre, string apellido, Rol perfil)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Perfil = perfil;
        }
    }
}
