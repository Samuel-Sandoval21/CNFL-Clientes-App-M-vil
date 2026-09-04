namespace CNFLAppMobile.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public string Categoria { get; set; } = string.Empty;
        public string ImagenUrl { get; set; } = string.Empty;
        public bool EnOferta { get; set; }
        public decimal? PrecioOferta { get; set; }
        public string Badge { get; set; } = string.Empty;
    }
}