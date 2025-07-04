using LibreriaUniversitaria.Entidades;

namespace LibreriaUniversitaria.BLL
{
    /// <summary>
    /// Exponer todos los valores de EstadoReserva para combos/filtros.
    /// </summary>
    public class EstadoReservaBLL
    {
        public EstadoReserva[] ObtenerTodos()
            => (EstadoReserva[])System.Enum.GetValues(typeof(EstadoReserva));
    }
}
