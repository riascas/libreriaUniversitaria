using DAL;
using ENT_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAT_Libreria
{
    public class LibroDAO
    {
        private Conexion conexion = new Conexion();

        public List<Libro> ObtenerTodos()
        {
            List<Libro> listaLibros = new List<Libro>();
            string consulta = "SELECT * FROM Libro";

            DataTable tabla = conexion.LeerPorComando(consulta);

            foreach (DataRow fila in tabla.Rows)
            {
                Libro libro = new Libro
                {
                    IdLibro = Convert.ToInt32(fila["idLibro"]),
                    ISBN = fila["ISBN"].ToString(),
                    Titulo = fila["Titulo"].ToString(),
                    Autor = fila["Autor"].ToString(),
                    PrecioLibro = Convert.ToDecimal(fila["PrecioLibro"]),
                    Disponible = Convert.ToBoolean(fila["Disponible"]),
                    UnaCategoriaLibro = new CategoriaLibro
                    {
                        IdCategoriaLibro = Convert.ToInt32(fila["idCategoriaLibro"]),
                        DescripcionCategoriaLibro = fila["DescripcionCategoriaLibro"].ToString()
                    },
                    UnEstadoLibro = new EstadoLibro
                    {
                        IdEstadoLibro = Convert.ToInt32(fila["idEstadoLibro"]),
                        DescripcionEstadoLibro = fila["DescripcionEstadoLibro"].ToString()
                    }
                };

                listaLibros.Add(libro);
            }

            return listaLibros;
        }

        public int Insertar(Libro libro)
        {
            string query = $@"
                INSERT INTO Libro (ISBN, Titulo, Autor, PrecioLibro, Disponible, idEstadoLibro, idCategoriaLibro)
                VALUES ('{libro.ISBN}', '{libro.Titulo}', '{libro.Autor}', {libro.PrecioLibro}, 
                        '{(libro.Disponible ? 1 : 0)}', {libro.UnEstadoLibro}, {libro.UnaCategoriaLibro})";

            return conexion.EscribirPorComando(query);
        }
    }
}
