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
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Domicilio");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Domicilio
                {
                    IdDomicilio = Convert.ToInt32(fila["idDomicilio"]),
                    Calle = fila["Calle"].ToString(),
                    Altura = Convert.ToInt32(fila["Altura"]),
                    UnaLocalidad = new Localidad
                    {
                        IdLocalidad = Convert.ToInt32(fila["idLocalidad"]),
                        NombreLocalidad = fila["NombreLocalidad"].ToString()
                    },
                });
            }
            return lista;
        }
    }
}
