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
    public class DomicilioDAO
    {
        private Conexion conexion = new Conexion();

        public List<Domicilio> ObtenerTodos()
        {
            List<Domicilio> lista = new List<Domicilio>();

            string consulta = @"
            SELECT d.idDomicilio, d.Calle, d.Altura,
                   l.idLocalidad, l.Descripcion AS NombreLocalidad,
                   m.idMunicipio, m.NombreMunicipio
            FROM Domicilio d
            INNER JOIN Localidad l ON d.FK_Localidad = l.idLocalidad
            INNER JOIN Municipio m ON l.FK_Municipio = m.idMunicipio";

            DataTable tabla = conexion.LeerPorComando(consulta);

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Domicilio dom = new Domicilio
                    {
                        IdDomicilio = Convert.ToInt32(fila["idDomicilio"]),
                        Calle = fila["Calle"].ToString(),
                        Altura = Convert.ToInt32(fila["Altura"]),
                        UnaLocalidad = new Localidad
                        {
                            IdLocalidad = Convert.ToInt32(fila["idLocalidad"]),
                            NombreLocalidad = fila["NombreLocalidad"].ToString(),
                            UnMunicipio = new Municipio
                            {
                                IdMunicipio = Convert.ToInt32(fila["idMunicipio"]),
                                NombreMunicipio = fila["NombreMunicipio"].ToString()
                            }
                        }
                    };

                    lista.Add(dom);
                }
            }

            return lista;
        }

        public int InsertarDomicilio(Domicilio domicilio)
        {
            string query = $"INSERT INTO Domicilio (Calle, Altura, FK_Localidad) " +
                           $"VALUES ('{domicilio.Calle}', {domicilio.Altura}, {domicilio.UnaLocalidad.IdLocalidad})";

            return conexion.EscribirPorComando(query);
        }
    }

}
