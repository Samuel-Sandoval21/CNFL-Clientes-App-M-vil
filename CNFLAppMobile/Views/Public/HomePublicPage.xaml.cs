using Microsoft.Maui.Controls;

namespace CNFLAppMobile.Views.Public;

public partial class HomePublicPage : ContentPage
{
    public HomePublicPage()
    {
        InitializeComponent();

        // Configurar el título de la página
        Title = "CNFL Clientes";
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Login");
    }

    private async void OnRegistroClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Registro");
    }

    private async void OnRecuperarClaveClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RecuperarClave");
    }
}