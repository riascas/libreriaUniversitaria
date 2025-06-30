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
    public class EditorialDAO
    {
        private Conexion conexion = new Conexion();

        public List<Editorial> ObtenerTodos()
        {
            List<Editorial> lista = new List<Editorial>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Editorial");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Editorial
                {
                    IdEditorial = Convert.ToInt32(fila["idEditorial"]),
                    NombreEditorial = fila["NombreEditorial"].ToString(),
                    Contacto = fila["Contacto"].ToString(),
                    CUIT = fila["CUIT"].ToString()
                });
            }
            return lista;
        }
    }
}
