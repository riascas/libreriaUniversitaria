using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Clase abstracta que representa un ítem genérico de detalle.
    /// Es la base para DetalleReserva y otros tipos de detalle similares.
    /// </summary>
    public abstract class ADetalle
    {
        // Libro asociado al detalle (ej. libro reservado o vendido)
        protected Libro _libro;

        // Cantidad de ejemplares del libro
        protected int _cantidad;

        /// <summary>
        /// Propiedad pública para acceder al libro.
        /// </summary>
        public Libro Libro
        {
            get { return _libro; }
            set { _libro = value; }
        }

        /// <summary>
        /// Propiedad pública para acceder a la cantidad.
        /// </summary>
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        /// <summary>
        /// Método abstracto que calcula el subtotal del detalle.
        /// Debe ser implementado por las subclases.
        /// </summary>
        /// <returns>Subtotal calculado (precio * cantidad)</returns>
        public abstract decimal Subtotal();
    }
}
