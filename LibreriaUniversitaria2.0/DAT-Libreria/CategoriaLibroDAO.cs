using DAL;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Libreria
{
    public class CategoriaLibroDAO
    {
        private Conexion conexion = new Conexion();

        public List<CategoriaLibro> ObtenerTodos()
        {
            List<CategoriaLibro> lista = new List<CategoriaLibro>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM CategoriaLibro");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new CategoriaLibro
                {
                    IdCategoriaLibro = Convert.ToInt32(fila["idCategoriaLibro"]),
                    DescripcionCategoriaLibro = fila["DescripcionCategoriaLibro"].ToString()
                });
            }
            return lista;
        }
    }
}
