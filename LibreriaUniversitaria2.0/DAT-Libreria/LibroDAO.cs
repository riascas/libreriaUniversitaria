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
            List<Libro> lista = new List<Libro>();
            DataTable tabla = conexion.LeerPorComando(@"SELECT l.*, c.DescripcionCategoria, e.DescripcionEstadoLibro
                                                     FROM Libro l
                                                     INNER JOIN CategoriaLibro c ON l.FK_CategoriaLibro = c.idCategoriaLibro
                                                     INNER JOIN EstadoLibro e ON l.FK_EstadoLibro = e.idEstadoLibro");

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Libro
                {
                    IdLibro = Convert.ToInt32(fila["idLibro"]),
                    ISNB = fila["ISNB"].ToString(),
                    Titulo = fila["Titulo"].ToString(),
                    Autor = fila["Autor"].ToString(),
                    PrecioLibro = Convert.ToDecimal(fila["PrecioLibro"]),
                    Disponible = Convert.ToBoolean(fila["Disponible"]),
                    UnaCategoriaLibro = new CategoriaLibro
                    {
                        IdCategoriaLibro = Convert.ToInt32(fila["FK_CategoriaLibro"]),
                        DescripcionCategoria = fila["DescripcionCategoria"].ToString()
                    },
                    UnEstadoLibro = new EstadoLibro
                    {
                        IdEstadoLibro = Convert.ToInt32(fila["FK_EstadoLibro"]),
                        DescripcionEstadoLibro = fila["DescripcionEstadoLibro"].ToString()
                    }
                });
            }
            return lista;
        }

        public int Insertar(Libro libro)
        {
            string query = $"INSERT INTO Libro (ISNB, Titulo, Autor, PrecioLibro, Disponible, FK_EstadoLibro, FK_CategoriaLibro) " +
                           $"VALUES ('{libro.ISNB}', '{libro.Titulo}', '{libro.Autor}', {libro.PrecioLibro}, '{(libro.Disponible ? 1 : 0)}', {libro.UnEstadoLibro.IdEstadoLibro}, {libro.UnaCategoriaLibro.IdCategoriaLibro})";

            conexion.EscribirPorComando(query);

            // Obtener ID del libro insertado
            DataTable tablaID = conexion.LeerPorComando("SELECT IDENT_CURRENT('Libro') AS UltimoID");
            return Convert.ToInt32(tablaID.Rows[0]["UltimoID"]);
        }
    }


}
