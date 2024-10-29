namespace Inventario.Models
{
    public class Categoria
    {
        public int? CategoriaId { get; set; }
        public string? Nombre { get; set; }

        public string? Descripcion { get; set; } // Descripción de la categoría
        public bool? Activo { get; set; } // Indica si la categoría está activa

        public ICollection<Producto>? Productos { get; set; }

    }
      
}
