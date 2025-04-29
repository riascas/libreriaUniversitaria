using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregamos los "using" necesarios para acceder a las clases de Entidades y Persistencia.
// Esto nos permite usar clases como Cliente, Producto, o el contexto de base de datos.

using LibreriaUniversitaria.Entidades;       // Modelos de datos (por ejemplo: Cliente, Producto, etc.)
using Persistencia;    // Acceso a la base de datos (Entity Framework, DAO, etc.)

// 📌 Aclaración para el equipo:
// Asegúrense de NO crear dependencias circulares entre proyectos.
// Cada capa debe referenciar solamente hacia abajo en la arquitectura, no en ambas direcciones.
// Si necesitan mover alguna clase a otra capa para evitarlo, háganlo y avisen en el grupo.

namespace LogicaNegocio
{
    using LibreriaUniversitaria.Entidades;

    public class DescuentoService
    {
        // Aplica un porcentaje de descuento al precio. Usado si el cliente es estudiante.
        public decimal AplicarDescuento(decimal precio, decimal porcentaje)
        {
            return precio - (precio * porcentaje / 100);
        }
    }
}