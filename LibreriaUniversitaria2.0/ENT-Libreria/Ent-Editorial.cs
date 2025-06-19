using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria
{
    public class Editorial
    {
        private string _contactoEditorial;
        private string _cuitEditorial;
        private string _nombreEditorial;

        public string ContactoEditorial
        {
            get { return _contactoEditorial; }
            set { _contactoEditorial = value; }
        }

        public string CuitEditorial
        {
            get { return _cuitEditorial; }
            set { _cuitEditorial = value; }
        }

        public string NombreEditorial
        {
            get { return _nombreEditorial; }
            set { _nombreEditorial = value; }
        }
    }
}
