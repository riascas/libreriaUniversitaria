using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using LibreriaUniversitaria.Entidades;

namespace Persistencia
{
    using Entidades;

    public class VentaRepository
    {
        private List<Venta> ventas = new List<Venta>();

        public void Agregar(Venta venta) => ventas.Add(venta);
        public List<Venta> ObtenerTodas() => ventas;
    }
}