namespace CNFLAppMobile.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public string NISE { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Plan { get; set; } = string.Empty;
        public decimal PrecioMensual { get; set; }
        public DateTime FechaContratacion { get; set; }
        public bool Activo { get; set; }
    }
}