using CNFLAppMobile.Views;

namespace CNFLAppMobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Registrar rutas para navegación
            Routing.RegisterRoute("HomePublicPage", typeof(HomePublicPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("RegistroPage", typeof(RegistroPage));
            Routing.RegisterRoute("RecuperarClavePage", typeof(RecuperarClavePage));
            Routing.RegisterRoute("InicioPage", typeof(InicioPage));
            Routing.RegisterRoute("TramitesPage", typeof(TramitesPage));
            Routing.RegisterRoute("PagosPage", typeof(PagosPage));
            Routing.RegisterRoute("TiendaPage", typeof(TiendaPage));
            Routing.RegisterRoute("ReportesPage", typeof(ReportesPage));
            Routing.RegisterRoute("PerfilPage", typeof(PerfilPage));
        }
    }
}