using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Clase que maneja la lógica de negocio relacionada con los libros.
    /// </summary>
    public class LibroBLL
    {
        private readonly LibroDAL libroDAL;

        public LibroBLL()
        {
            libroDAL = new LibroDAL();
        }

        // Insertar un libro nuevo
        public void Insertar(Libro libro)
        {
            libroDAL.Insertar(libro);
        }

        // Traer todos los libros registrados
        public List<Libro> ObtenerTodos()
        {
            return libroDAL.ObtenerTodos();
        }

        // Buscar un libro por ISBN (devuelve solo el primero que encuentre)
        public Libro BuscarPorISBN(string isbn)
        {
            List<Libro> lista = libroDAL.BuscarPorISBN(isbn);
            return lista.FirstOrDefault(); // Si no hay coincidencias, devuelve null
        }

        // Buscar por título (coincidencia parcial)
        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libroDAL.BuscarPorTitulo(titulo);
        }

        // Buscar por autor (coincidencia parcial)
        public List<Libro> BuscarPorAutor(string autor)
        {
            return libroDAL.BuscarPorAutor(autor);
        }

        // Buscar por editorial (coincidencia parcial)
        public List<Libro> BuscarPorEditorial(string editorial)
        {
            return libroDAL.BuscarPorEditorial(editorial);
        }

        // Actualizar datos del libro
        public void Actualizar(Libro libro)
        {
            libroDAL.Actualizar(libro);
        }

        // Eliminar un libro por Id
        public void Eliminar(int idLibro)
        {
            libroDAL.Eliminar(idLibro);
        }

        // Actualiza el stock del libro
        public void ActualizarStock(int idLibro, int nuevoStock)
        {
            libroDAL.ActualizarStock(idLibro, nuevoStock);
        }

        // Cambia el estado de un libro (activo/inactivo)
        public void CambiarEstado(int idLibro, bool nuevoEstado)
        {
            libroDAL.CambiarEstado(idLibro, nuevoEstado);
        }

        // Control especial de stock: alerta si llega a 4 o 0 unidades
        public bool VerificarAlertaStock(int idLibro, out string mensajeAlerta)
        {
            Libro libro = libroDAL.BuscarPorId(idLibro);
            mensajeAlerta = "";

            if (libro != null)
            {
                if (libro.Stock == 0)
                {
                    mensajeAlerta = $"¡Alerta! El libro '{libro.Titulo}' ya no tiene stock.";
                    return true;
                }
                else if (libro.Stock <= 4)
                {
                    mensajeAlerta = $"Atención: El libro '{libro.Titulo}' tiene solo {libro.Stock} unidades disponibles.";
                    return true;
                }
            }



            return false;
        }
    }
}
