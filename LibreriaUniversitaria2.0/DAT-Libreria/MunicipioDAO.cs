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
    public class MunicipioDAO
    {
        private Conexion conexion = new Conexion();

        public List<Municipio> ObtenerTodos()
        {
            List<Municipio> lista = new List<Municipio>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Municipio");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Municipio
                {
                    IdMunicipio = Convert.ToInt32(fila["idMunicipio"]),
                    NombreMunicipio = fila["NombreMunicipio"].ToString()
                });
            }
            return lista;
        }
    }
}
