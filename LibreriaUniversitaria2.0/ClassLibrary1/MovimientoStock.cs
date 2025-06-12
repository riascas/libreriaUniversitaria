using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.Entidades
{
    // Clase que representa un movimiento de stock (aumento o disminucion)
    public class MovimientoStock
    {
        // Atributos privados
        private int _idMovimiento;
        private DateTime _fecha;
        private Libro _libro;
        private Empleado _empleado;
        private int _cantidad;
        private string _tipoMovimiento;

        // Propiedades publicas
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
            set { _cantidad = value; }
        }

        public string TipoMovimiento
        {
            get { return _tipoMovimiento; }
            set { _tipoMovimiento = value; }
        }

        // Constructor vacio
        public MovimientoStock() { }

        // Constructor con parametros
        public MovimientoStock(int idMovimiento, DateTime fecha, Libro libro, Empleado empleado, int cantidad, string tipoMovimiento)
        {
            _idMovimiento = idMovimiento;
            _fecha = fecha;
            _libro = libro;
            _empleado = empleado;
            _cantidad = cantidad;
            _tipoMovimiento = tipoMovimiento;
        }

        // Metodo ToString para mostrar resumen del movimiento
        public override string ToString()
        {
            return $"{Fecha.ToShortDateString()} - {TipoMovimiento} - {Libro.Titulo} x{Cantidad}";
        }
    }
}
