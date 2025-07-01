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
    public class ClienteDAO
    {
        private Conexion conexion = new Conexion();

        public List<Cliente> ObtenerTodos()
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = @"
            SELECT c.idCliente, c.Estudiante,
                   p.idPersona, p.Nombre, p.Apellido, p.DNI, p.Email,
                   d.idDomicilio, d.Calle, d.Altura,
                   l.idLocalidad, l.Descripcion AS NombreLocalidad,
                   m.idMunicipio, m.NombreMunicipio
            FROM Cliente c
            INNER JOIN Persona p ON c.FK_Persona = p.idPersona
            INNER JOIN Domicilio d ON p.FK_Domicilio = d.idDomicilio
            INNER JOIN Localidad l ON d.FK_Localidad = l.idLocalidad
            INNER JOIN Municipio m ON l.FK_Municipio = m.idMunicipio";

            DataTable tabla = conexion.LeerPorComando(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Cliente cliente = new Cliente
                {
                    IdCliente = Convert.ToInt32(fila["idCliente"]),
                    EsEstudiante = Convert.ToBoolean(fila["EsEstudiante"]),
                    UnaPersona = new Persona
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
                    }
                };

                lista.Add(cliente);
            }

            return lista;
        }

        public int InsertarCliente(Cliente cliente)
        {
            string query = $@"
            INSERT INTO Cliente (EsEstudiante, FK_Persona)
            VALUES ('{(cliente.EsEstudiante ? 1 : 0)}', {cliente.UnaPersona.IdPersona})";

            return conexion.EscribirPorComando(query);
        }
    }

}
