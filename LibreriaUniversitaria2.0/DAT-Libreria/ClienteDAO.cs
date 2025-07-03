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
                SELECT c.idCliente, c.EsEstudiante, 
                       p.Nombre, p.Apellido, p.DNI, p.Email,
                       d.Calle, d.Altura,
                       l.NombreLocalidad
                FROM Cliente c
                INNER JOIN Persona p ON c.FK_Persona = p.idPersona
                INNER JOIN Domicilio d ON p.idPersona = d.FK_Persona
                INNER JOIN Localidad l ON d.FK_Localidad = l.idLocalidad";

            DataTable tabla = conexion.LeerPorComando(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Cliente cli = new Cliente
                {
                    IdCliente = Convert.ToInt32(fila["idCliente"]),
                    EsEstudiante = Convert.ToBoolean(fila["EsEstudiante"]),
                    UnaPersona = new Persona
                    {
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        DNI = fila["DNI"].ToString(),
                        Email = fila["Email"].ToString(),
                        UnDomicilio = new Domicilio
                        {
                            Calle = fila["Calle"].ToString(),
                            Altura = Convert.ToInt32(fila["Altura"]),
                            UnaLocalidad = new Localidad
                            {
                                NombreLocalidad = fila["NombreLocalidad"].ToString()
                            }
                        }
                    }
                };
                lista.Add(cli);
            }
            return lista;
        }

        public int Insertar(Cliente cliente)
        {
            // 1. Insertar Persona
            string queryPersona = $"INSERT INTO Persona (Nombre, Apellido, DNI, Email) VALUES ('{cliente.UnaPersona.Nombre}', '{cliente.UnaPersona.Apellido}', '{cliente.UnaPersona.DNI}', '{cliente.UnaPersona.Email}')";
            conexion.EscribirPorComando(queryPersona);

            // 2. Obtener último idPersona
            int idPersona = Convert.ToInt32(conexion.LeerPorComando("SELECT MAX(idPersona) AS id FROM Persona").Rows[0]["id"]);

            // 3. Insertar Cliente
            string queryCliente = $"INSERT INTO Cliente (EsEstudiante, FK_Persona) VALUES ('{(cliente.EsEstudiante ? 1 : 0)}', {idPersona})";
            conexion.EscribirPorComando(queryCliente);

            // 4. Insertar Domicilio
            string queryDomicilio = $"INSERT INTO Domicilio (Calle, Altura, FK_Persona, FK_Localidad) VALUES ('{cliente.UnaPersona.UnDomicilio.Calle}', {cliente.UnaPersona.UnDomicilio.Altura}, {idPersona}, {cliente.UnaPersona.UnDomicilio.UnaLocalidad.IdLocalidad})";
            return conexion.EscribirPorComando(queryDomicilio);
        }
    }

}
