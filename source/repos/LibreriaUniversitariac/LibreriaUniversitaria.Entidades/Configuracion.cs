namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Parámetros globales de la aplicación.
    /// </summary>
    public class Configuracion
    {
        /// <summary>Nombre de la librería.</summary>
        public string NombreLibreria { get; set; }

        /// <summary>Porcentaje de descuento para estudiantes (ej. 10.0).</summary>
        public decimal DescuentoEstudiante { get; set; }

        /// <summary>Días máximos que puede mantenerse una reserva.</summary>
        public int DiasMaxReserva { get; set; }
    }
}
