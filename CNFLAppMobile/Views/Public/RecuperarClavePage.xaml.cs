namespace CNFLAppMobile.Views.Public;

public partial class RecuperarClavePage : ContentPage
{
    public RecuperarClavePage()
    {
        InitializeComponent();
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Enviado", "Se ha enviado un enlace a tu correo electrónico", "OK");
        await Shell.Current.GoToAsync("Login");
    }

    public Command NavigateToLoginCommand => new Command(async () => await Shell.Current.GoToAsync("Login"));
}