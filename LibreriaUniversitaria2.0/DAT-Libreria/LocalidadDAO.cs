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
            string consulta = @"
            SELECT l.idLocalidad, l.NombreLocalidad, 
                   m.idMunicipio, m.NombreMunicipio
            FROM Localidad l
            INNER JOIN Municipio m ON l.FK_Municipio = m.idMunicipio";

            DataTable tabla = conexion.LeerPorComando(consulta);

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Localidad localidad = new Localidad
                    {
                        IdLocalidad = Convert.ToInt32(fila["idLocalidad"]),
                        NombreLocalidad = fila["NombreLocalidad"].ToString(),
                        UnMunicipio = new Municipio
                        {
                            IdMunicipio = Convert.ToInt32(fila["idMunicipio"]),
                            NombreMunicipio = fila["NombreMunicipio"].ToString()
                        }
                    };

                    lista.Add(localidad);
                }
            }

            return lista;
        }

        public int InsertarLocalidad(Localidad localidad)
        {
            string query = $"INSERT INTO Localidad (Descripcion, FK_Municipio) " +
                           $"VALUES ('{localidad.NombreLocalidad}', {localidad.UnMunicipio.IdMunicipio})";

            return conexion.EscribirPorComando(query);
        }
    }


}
