using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        private int idRol;
        private string descripcionRol;

        public int IdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public string DescripcionRol
        {
            get { return descripcionRol; }
            set { descripcionRol = value; }
        }

        public void AsignarRol()
        {

        }
    }
}
