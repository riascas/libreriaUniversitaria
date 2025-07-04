using System;
using LibreriaUniversitaria.DAL;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Lógica de negocio para el movimiento de stock de libros.
    /// </summary>
    public class MovimientoStockBLL
    {
        private readonly LibroDAL _libroDal = new LibroDAL();

        /// <summary>
        /// Ajusta el stock de un libro tras una operación de compra/venta.
        /// </summary>
        public void AjustarStock(int idLibro, int cantidad, bool esEntrada)
        {
            // Si es entrada sumamos, si es salida restamos.
            var libro = _libroDal.ObtenerPorId(idLibro);
            if (libro == null) throw new Exception($"Libro Id={idLibro} no encontrado.");

            int nuevoStock = esEntrada
                ? libro.Stock + cantidad
                : libro.Stock - cantidad;

            if (nuevoStock < 0) throw new Exception("Stock insuficiente.");

            _libroDal.ActualizarStock(idLibro, nuevoStock);
        }
    }
}
