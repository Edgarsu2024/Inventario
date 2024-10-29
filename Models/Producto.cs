using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Producto
    {
        public int? ProductoId { get; set; }
        public string? Nombre { get; set; }
        public decimal? Precio { get; set; }
        public int? CategoriaId { get; set; }

        public int? StockDisponible { get; set; } // Control del stock disponible
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}",ApplyFormatInEditMode =true)]
        public DateTime? FechaIngreso { get; set; } // Fecha de ingreso del producto al inventario
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? FechaVencimiento { get; set; } // Fecha de vencimiento (si aplica)
        public string? Descripcion { get; set; } // Descripción adicional del producto
        //public string? CodigoBarras { get; set; } // Código de barras para el producto
        public string? Estado { get; set; } // Estado del producto (activo, descontinuado, oferta, etc.)
        public Categoria? Categoria { get; set; }
        public int? ProveedorId { get; set; }
        public Proveedor? Proveedor { get; set; }
    }

}
