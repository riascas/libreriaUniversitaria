using LibreriaUniversitaria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Persistencia
{
    using LibreriaUniversitaria.Entidades;

    // Repositorio simulado para manejar operaciones con clientes
    public class ClienteRepository
    {
        // Lista simulada como "base de datos en memoria"
        private List<Cliente> clientes = new List<Cliente>();

        // Agrega un cliente a la lista
        public void Agregar(Cliente cliente) => clientes.Add(cliente);

        // Devuelve todos los clientes registrados
        public List<Cliente> ObtenerTodos() => clientes;
    }
}

/* orientado a EF (futuro):
public class ClienteRepository
{
    private readonly LibreriaDbContext _context;

    public ClienteRepository(LibreriaDbContext context)
    {
        _context = context;
    }

    public async Task AgregarAsync(Cliente cliente)
    {
        _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Cliente>> ObtenerTodosAsync()
    {
        return await _context.Clientes.ToListAsync();
    }
}
*/