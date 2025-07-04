using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT_Libreria

{
    public class CategoriaLibro
    {
        private int _idCategoriaLibro;
        private string _descripcionCategoria;

        public int IdCategoriaLibro
        {
            get { return _idCategoriaLibro; }
            set { _idCategoriaLibro = value; }
        }
        public string DescripcionCategoria
        {
            get { return _descripcionCategoria; }
            set { _descripcionCategoria = value; }
        }
    }
}
