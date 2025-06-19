using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class CategoriaLibro
    {
        private string _descripcionCategoriaLibro;

        public string DescripcionCategoriaLibro
        {
            get { return _descripcionCategoriaLibro; }
            set { _descripcionCategoriaLibro = value; }
        }
    }
}
