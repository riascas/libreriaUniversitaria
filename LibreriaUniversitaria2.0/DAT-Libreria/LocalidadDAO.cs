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
    public class LocalidadDAO
    {
        private Conexion conexion = new Conexion();

        public List<Localidad> ObtenerTodos()
        {
            List<Localidad> lista = new List<Localidad>();
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Localidad");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Localidad
                {
                    IdLocalidad = Convert.ToInt32(fila["idLocalidad"]),
                    NombreLocalidad = fila["Descripcion"].ToString(),
                    UnMunicipio = new Municipio
                    {
                        IdMunicipio = Convert.ToInt32(fila["idMunicipio"]),
                        NombreMunicipio = fila["NombreMunicipio"].ToString()
                    }
                });
            }
            return lista;
        }
    }
}
