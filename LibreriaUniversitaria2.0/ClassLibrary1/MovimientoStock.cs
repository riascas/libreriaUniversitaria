using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un movimiento de stock (entrada o salida) de un libro.
    /// </summary>
    public class MovimientoStock
    {
        // Campos privados
        private int _idMovimiento;
        private DateTime _fecha;
        private Libro _libro;
        private Empleado _empleado;
        private int _cantidad;
        private TipoMovimientoStock _tipoMovimiento;

        // Propiedades públicas
        public int IdMovimiento
        {
            get { return _idMovimiento; }
            set { _idMovimiento = value; }
        }

        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        public Empleado Empleado
        {
            get { return _empleado; }
            set { _empleado = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; } // Validación adicional puede agregarse en la lógica
        }

        public TipoMovimientoStock TipoMovimiento
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }

        // Constructor vacío
        public MovimientoStock() { }

        // Constructor con parámetros
        public MovimientoStock(int idMovimiento, DateTime fecha, Libro libro, Empleado empleado, int cantidad, TipoMovimientoStock tipoMovimiento)
        {
            _idMovimiento = idMovimiento;
            _fecha = fecha;
            _libro = libro;
            _empleado = empleado;
            _cantidad = cantidad;
            _tipoMovimiento = tipoMovimiento;
        }

        /// <summary>
        /// Representación textual del movimiento, útil para listar en formularios.
        /// </summary>
        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()} - {TipoMovimiento} - {Libro.Titulo} x{Cantidad}";
        }
    }

    /// <summary>
    /// Enum que representa los tipos posibles de movimiento de stock.
    /// </summary>
    public enum TipoMovimientoStock
    {
        Alta,   // Entrada de stock (compra, carga inicial, etc.)
        Baja,   // Salida de stock (venta, reserva vencida, etc.)
        Ajuste  // Ajustes manuales de stock (por error o auditoría)
    }
}
