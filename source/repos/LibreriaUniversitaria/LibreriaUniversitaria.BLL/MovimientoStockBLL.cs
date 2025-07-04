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
    /// Lógica de negocio para la gestión de movimientos de stock.
    /// </summary>
    public class MovimientoStockBLL
    {
        private readonly MovimientoStockDAL movimientoDAL;
        private readonly LibroDAL libroDAL;

        public MovimientoStockBLL()
        {
            movimientoDAL = new MovimientoStockDAL();
            libroDAL = new LibroDAL();
        }

        /// <summary>
        /// Registra un nuevo movimiento de stock, validando reglas de negocio.
        /// </summary>
        /// <param name="movimiento">Movimiento de stock a registrar</param>
        public void RegistrarMovimiento(MovimientoStock movimiento)
        {
            if (movimiento.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            // Si es un egreso, validar que haya stock disponible suficiente
            if (movimiento.TipoMovimiento == "Egreso")
            {
                int stockActual = movimientoDAL.ObtenerStockPorId(movimiento.IdLibro);


                if (stockActual < movimiento.Cantidad)
                    throw new InvalidOperationException("No hay stock suficiente para realizar el egreso.");

                // Resta al stock
                libroDAL.ActualizarStock(movimiento.IdLibro, -movimiento.Cantidad);
            }
            else if (movimiento.TipoMovimiento == "Ingreso")
            {
                // Suma al stock
                libroDAL.ActualizarStock(movimiento.IdLibro, movimiento.Cantidad);
            }
            else
            {
                throw new ArgumentException("Tipo de movimiento no válido. Debe ser 'Ingreso' o 'Egreso'.");
            }

            // Registrar el movimiento en la base
            movimiento.Fecha = DateTime.Now;
            movimientoDAL.InsertarMovimiento(movimiento);
        }

        /// <summary>
        /// Devuelve todos los movimientos registrados.
        /// </summary>
        public List<MovimientoStock> ObtenerHistorial()
        {
            return movimientoDAL.ObtenerTodos();
        }
    }
}


