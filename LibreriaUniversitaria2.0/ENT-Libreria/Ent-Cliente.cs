using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class Cliente : Persona
    {
        private bool _esEstudiante;

        public bool EsEstudiante
        {
            get { return _esEstudiante; }
            set { _esEstudiante = value; }
        }
    }
}
