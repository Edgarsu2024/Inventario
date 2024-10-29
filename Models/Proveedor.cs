namespace Inventario.Models
{
    public class Proveedor
    {
        public int? ProveedorId { get; set; }
        public string? Nombre { get; set; }
        public string? Telefono { get; set; }

        public string? Email { get; set; } // Email del proveedor
        public string? Direccion { get; set; } // Dirección del proveedor
        public bool? Activo { get; set; } // Indica si el proveedor está activo

        public ICollection<Producto>? Productos { get; set; }
    }

}
