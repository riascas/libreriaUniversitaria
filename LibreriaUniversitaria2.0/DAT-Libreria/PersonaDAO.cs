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
    public class PersonaDAO
    {
        private Conexion conexion = new Conexion();

        public List<Persona> ObtenerTodos()
        {
            List<Persona> lista = new List<Persona>();

            string consulta = @"
            SELECT p.idPersona, p.Nombre, p.Apellido, p.DNI, p.Email,
                   d.idDomicilio, d.Calle, d.Altura,
                   l.idLocalidad, l.Descripcion AS NombreLocalidad,
                   m.idMunicipio, m.NombreMunicipio
            FROM Persona p
            INNER JOIN Domicilio d ON p.FK_Domicilio = d.idDomicilio
            INNER JOIN Localidad l ON d.FK_Localidad = l.idLocalidad
            INNER JOIN Municipio m ON l.FK_Municipio = m.idMunicipio";

            DataTable tabla = conexion.LeerPorComando(consulta);

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Persona persona = new Persona
                    {
                        IdPersona = Convert.ToInt32(fila["idPersona"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        DNI = fila["DNI"].ToString(),
                        Email = fila["Email"].ToString(),
                        UnDomicilio = new Domicilio
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
                        }
                    };

                    lista.Add(persona);
                }
            }

            return lista;
        }

        public int InsertarPersona(Persona persona)
        {
            string query = $@"
            INSERT INTO Persona (Nombre, Apellido, DNI, Email, FK_Domicilio)
            VALUES ('{persona.Nombre}', '{persona.Apellido}', '{persona.DNI}', 
                    '{persona.Email}', {persona.UnDomicilio.IdDomicilio})";

            return conexion.EscribirPorComando(query);
        }
    }

}
