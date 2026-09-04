namespace CNFLAppMobile.Views.Main;

public partial class PerfilPage : ContentPage
{
    public PerfilPage()
    {
        InitializeComponent();
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