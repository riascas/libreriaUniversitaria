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
        private int _idCliente;
        private Persona _unaPersona;

        public bool EsEstudiante
        {
            get { return _esEstudiante; }
            set { _esEstudiante = value; }
        }
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        
        public Persona UnaPersona
        {
            get { return _unaPersona; }
            set { _unaPersona = value; }
        }
    }
}
