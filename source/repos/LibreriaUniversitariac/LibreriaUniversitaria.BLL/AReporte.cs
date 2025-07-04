using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Clase abstracta base para todos los reportes.
    /// Define las propiedades comunes y el método que cada reporte debe implementar.
    /// </summary>
    public abstract class AReporte
    {
        // Fechas para filtrar el reporte
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }

        /// <summary>
        /// Constructor base que recibe fechas iniciales para el reporte.
        /// </summary>
        /// <param name="fechaDesde">Fecha de inicio del rango</param>
        /// <param name="fechaHasta">Fecha fin del rango</param>
        protected AReporte(DateTime fechaDesde, DateTime fechaHasta)
        {
            FechaDesde = fechaDesde;
            FechaHasta = fechaHasta;
        }

        /// <summary>
        /// Método abstracto que debe implementar cada reporte para obtener sus datos.
        /// </summary>
        /// <returns>Un DataTable con los datos del reporte</returns>
        public abstract DataTable ObtenerDatos();
    }
}
