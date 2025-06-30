using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Editorial

    {
        private int _idEditorial;
        private string _contacto;
        private string _cuit;
        private string _nombreEditorial;

        public int IdEditorial
        {
            get { return _idEditorial; }
            set { _idEditorial = value; }
        }
        public string Contacto
        {
            get { return _contacto; }
            set { _contacto = value; }
        }

        public string CUIT
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        public string NombreEditorial
        {
            get { return _nombreEditorial; }
            set { _nombreEditorial = value; }
        }
    }
}
