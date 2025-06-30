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

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    lista.Add(new Municipio
                    {
                        IdMunicipio = Convert.ToInt32(fila["idMunicipio"]),
                        NombreMunicipio = fila["NombreMunicipio"].ToString()
                    });
                }
            }

            return lista;
        }

        public int InsertarMunicipio(Municipio municipio)
        {
            string query = $"INSERT INTO Municipio (NombreMunicipio) VALUES ('{municipio.NombreMunicipio}')";
            return conexion.EscribirPorComando(query);
        }
    }
}
