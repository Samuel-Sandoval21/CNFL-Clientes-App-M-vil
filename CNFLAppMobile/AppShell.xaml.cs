using Microsoft.Maui.Controls;

namespace CNFLAppMobile;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar rutas para navegación
        Routing.RegisterRoute("HomePublic", typeof(Views.Public.HomePublicPage));
        Routing.RegisterRoute("Login", typeof(Views.Public.LoginPage));
        Routing.RegisterRoute("Registro", typeof(Views.Public.RegistroPage));
        Routing.RegisterRoute("RecuperarClave", typeof(Views.Public.RecuperarClavePage));

        Routing.RegisterRoute("Inicio", typeof(Views.Main.InicioPage));
        Routing.RegisterRoute("Pagos", typeof(Views.Main.PagosPage));
        Routing.RegisterRoute("Reportes", typeof(Views.Main.ReportesPage));
        Routing.RegisterRoute("Tienda", typeof(Views.Main.TiendaPage));
        Routing.RegisterRoute("Tramites", typeof(Views.Main.TramitesPage));
        Routing.RegisterRoute("Perfil", typeof(Views.Main.PerfilPage));
    }
}