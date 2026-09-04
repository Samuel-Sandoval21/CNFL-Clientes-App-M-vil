namespace CNFLAppMobile.Models
{
    public class Notificacion
    {
        public int Id { get; set; }
        public string NISE { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }
        public bool Leida { get; set; }
        public string Tipo { get; set; } = string.Empty;
    }
}