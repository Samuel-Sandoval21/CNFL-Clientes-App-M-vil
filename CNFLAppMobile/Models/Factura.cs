namespace CNFLAppMobile.Models
{
    public class Factura
    {
        public int Id { get; set; }
        public string NISE { get; set; } = string.Empty;
        public string Periodo { get; set; } = string.Empty;
        public DateTime FechaEmision { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Monto { get; set; }
        public decimal ConsumoKWh { get; set; }
        public bool Pagada { get; set; }
    }
}