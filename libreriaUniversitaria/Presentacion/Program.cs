using Persistencia;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear los repositorios
            var libroRepo = new LibroRepository();
            var clienteRepo = new ClienteRepository();
            var ventaRepo = new VentaRepository(clienteRepo, libroRepo);

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
                Console.WriteLine("1. Listar Libros");
                Console.WriteLine("2. Listar Clientes");
                Console.WriteLine("3. Listar Ventas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine() ?? "";

                switch (opcion)
                {
                    case "1":
                        ListarLibros(libroRepo);
                        break;
                    case "2":
                        ListarClientes(clienteRepo);
                        break;
                    case "3":
                        ListarVentas(ventaRepo);
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }

        static void ListarLibros(LibroRepository repo)
        {
            Console.WriteLine("\n--- Lista de Libros ---");
            foreach (var libro in repo.ObtenerTodos())
            {
                Console.WriteLine($"Id: {libro.Id} | Título: {libro.Titulo} | Autor: {libro.Autor}");
            }
        }

        static void ListarClientes(ClienteRepository repo)
        {
            Console.WriteLine("\n--- Lista de Clientes ---");
            foreach (var cliente in repo.ObtenerTodos())
            {
                Console.WriteLine($"Id: {cliente.Id} | Nombre: {cliente.Nombre} | Email: {cliente.Email}");
            }
        }

        static void ListarVentas(VentaRepository repo)
        {
            Console.WriteLine("\n--- Lista de Ventas ---");
            foreach (var venta in repo.ObtenerTodas())
            {
                Console.WriteLine($"Id Venta: {venta.Id} | Cliente: {venta.Cliente.Nombre} | Libro: {venta.Libro.Titulo} | Fecha: {venta.FechaVenta}");
            }
        }
    }
}
