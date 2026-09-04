namespace CNFLAppMobile.Views.Main;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    private async void OnReportesClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Reportes");
    }

    private async void OnPagosClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Pagos");
    }

    private async void OnTiendaClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Tienda");
    }

    private async void OnTramitesClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Tramites");
    }

    private async void OnPerfilClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Perfil");
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        bool confirm = await DisplayAlertAsync("Cerrar Sesión", "¿Estás seguro de que deseas salir?", "Sí", "No");
        if (confirm)
        {
            await Shell.Current.GoToAsync("//HomePublic");
        }
    }
}