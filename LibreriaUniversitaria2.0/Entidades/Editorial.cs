using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    public class Editorial
    {
        private int idEditorial;
        private string nombreEditorial;
        private long cuit;
        private string telefono;

        public int IdEditorial
        {
            get { return idEditorial; }
            set { idEditorial = value; }
        }

        public string NombreEditorial
        {
            get { return nombreEditorial; }
            set { nombreEditorial = value; }
        }

        public long Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public void CargarEditorial()
        {

        }
    }
}
