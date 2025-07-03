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
    public class EmpleadoDAO
    {
        private Conexion conexion = new Conexion();

        public List<Empleado> ObtenerTodos()
        {
            List<Empleado> lista = new List<Empleado>();

            string consulta = @"
            SELECT e.idEmpleado, e.Usuario, e.Clave,
                   p.idPersona, p.Nombre, p.Apellido, p.DNI, p.Email,
                   d.idDomicilio, d.Calle, d.Altura,
                   l.idLocalidad, l.NombreLocalidad,
                   m.idMunicipio, m.NombreMunicipio,
                   r.idRolEmpleado, r.Rol
            FROM Empleado e
            INNER JOIN Persona p ON e.FK_Persona = p.idPersona
            INNER JOIN Domicilio d ON d.FK_Persona = p.idPersona
            INNER JOIN Localidad l ON d.FK_Localidad = l.idLocalidad
            INNER JOIN Municipio m ON l.FK_Municipio = m.idMunicipio
            INNER JOIN RolEmpledo r ON e.FK_RolEmpleado = r.idRolEmpleado";

            DataTable tabla = conexion.LeerPorComando(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Empleado emp = new Empleado
                {
                    IdEmpleado = Convert.ToInt32(fila["idEmpleado"]),
                    Usuario = fila["Usuario"].ToString(),
                    Clave = fila["Clave"].ToString(),
                    UnRol = new RolEmpleado
                    {
                        IdRolEmpleado = Convert.ToInt32(fila["idRolEmpleado"]),
                        Rol = fila["Rol"].ToString()
                    },
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

                lista.Add(emp);
            }

            return lista;
        }

        public int AltaEmpleado(Empleado emp)
        {
            // 1. Insertar Persona
            string queryPersona = $"INSERT INTO Persona (Nombre, Apellido, DNI, Email) VALUES ('{emp.UnaPersona.Nombre}', '{emp.UnaPersona.Apellido}', '{emp.UnaPersona.DNI}', '{emp.UnaPersona.Email}')";
            conexion.EscribirPorComando(queryPersona);

            // 2. Obtener el último ID persona insertado
            int idPersona = Convert.ToInt32(conexion.LeerPorComando("SELECT MAX(idPersona) AS id FROM Persona").Rows[0]["id"]);

            // 3. Insertar Empleado
            string queryEmpleado = $"INSERT INTO Empleado (Usuario, Clave, FK_Persona, FK_RolEmpleado) VALUES ('{emp.Usuario}', '{emp.Clave}', {idPersona}, {emp.UnRol.IdRolEmpleado})";
            conexion.EscribirPorComando(queryEmpleado);

            // 4. Insertar Domicilio
            string queryDomicilio = $"INSERT INTO Domicilio (Calle, Altura, FK_Persona, FK_Localidad) VALUES ('{emp.UnaPersona.UnDomicilio.Calle}', {emp.UnaPersona.UnDomicilio.Altura}, {idPersona}, {emp.UnaPersona.UnDomicilio.UnaLocalidad.IdLocalidad})";
            return conexion.EscribirPorComando(queryDomicilio);
        }

        public Empleado BuscarPorUsuarioYClave(string usuario, string clave)
        {
            string query = $@"SELECT e.idEmpleado, e.Usuario, e.Clave, r.idRolEmpleado, r.Rol, p.idPersona, p.Nombre, p.Apellido, p.DNI, p.Email
                            FROM Empleado e
                            INNER JOIN RolEmpledo r ON e.FK_RolEmpleado = r.idRolEmpleado
                            INNER JOIN Persona p ON e.FK_Persona = p.idPersona
                            WHERE e.Usuario = '{usuario}' AND e.Clave = '{clave}'";

            DataTable tabla = conexion.LeerPorComando(query);

            if (tabla.Rows.Count == 0)
                return null;

            DataRow fila = tabla.Rows[0];

            return new Empleado
            {
                IdEmpleado = Convert.ToInt32(fila["idEmpleado"]),
                Usuario = fila["Usuario"].ToString(),
                Clave = fila["Clave"].ToString(),
                UnRol = new RolEmpleado
                {
                    IdRolEmpleado = Convert.ToInt32(fila["idRolEmpleado"]),
                    Rol = fila["Rol"].ToString()
                },
                UnaPersona = new Persona
                {
                    IdPersona = Convert.ToInt32(fila["idPersona"]),
                    Nombre = fila["Nombre"].ToString(),
                    Apellido = fila["Apellido"].ToString(),
                    DNI = fila["DNI"].ToString(),
                    Email = fila["Email"].ToString()
                }
            };
        }
    }
}
