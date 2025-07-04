namespace LibreriaUniversitaria.Entidades
{
    /// <summary>
    /// Representa un proveedor (editorial) de libros.
    /// </summary>
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string CUIT { get; set; }
        public string Telefono { get; set; }

        // Alias para facilitar acceso
        public int Id => IdProveedor;
    }
}
