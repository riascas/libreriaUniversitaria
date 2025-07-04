using System;
using System.Collections.Generic;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    public class LibroBLL
    {
        private readonly LibroDAL _dal = new LibroDAL();

        public List<Libro> ObtenerTodos() => _dal.ObtenerTodos();
        public Libro ObtenerPorId(int id) => _dal.ObtenerPorId(id);
        public void Insertar(Libro l) => _dal.Insertar(l);
        public void Actualizar(Libro l) => _dal.Actualizar(l);
        public void Eliminar(int id) => _dal.Eliminar(id);
        public void CambiarEstado(int id, bool e) => _dal.CambiarEstado(id, e);
        public void AjustarStock(int id, int d) => _dal.ActualizarStock(id, d);

        public List<Libro> BuscarPorTitulo(string t) => _dal.BuscarPorTitulo(t);
        public List<Libro> BuscarPorAutor(string t) => _dal.BuscarPorAutor(t);
        public List<Libro> BuscarPorISBN(string t) => _dal.BuscarPorISBN(t);
        public List<Libro> BuscarPorCategoria(string t) => _dal.BuscarPorCategoria(t);
        public List<Libro> BuscarPorEditorial(string t) => _dal.BuscarPorEditorial(t);
    }
}
