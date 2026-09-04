namespace CNFLAppMobile.Models
{
    public class Averia
    {
        public int Id { get; set; }
        public string NISE { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaReporte { get; set; }
        public EstadoAveria Estado { get; set; }
        public string FotoBase64 { get; set; } = string.Empty;
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }

    public enum EstadoAveria
    {
        Reportado,
        EnRevision,
        EnCamino,
        Resuelto
    }
}