using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaUniversitaria.Entidades;


namespace Persistencia
{
    using LibreriaUniversitaria.Entidades;

    // Repositorio simulado para manejar operaciones con ventas
    public class VentaRepository
    {
        // Lista simulada como "base de datos en memoria"
        private List<Venta> ventas = new List<Venta>();

        // Agrega una venta a la lista
        public void Agregar(Venta venta) => ventas.Add(venta);

        // Devuelve todas las ventas registradas
        public List<Venta> ObtenerTodas() => ventas;
    }
}