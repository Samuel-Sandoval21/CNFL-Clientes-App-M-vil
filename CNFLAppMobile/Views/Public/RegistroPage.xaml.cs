namespace CNFLAppMobile.Views.Public;

public partial class RegistroPage : ContentPage
{
    public RegistroPage()
    {
        InitializeComponent();
    }

    private async void OnRegistroClicked(object sender, EventArgs e)
    {
        // Aquí iría la lógica de registro con el backend
        await DisplayAlertAsync("Éxito", "Cuenta creada correctamente", "OK");
        await Shell.Current.GoToAsync("Login");
    }

    public Command NavigateToLoginCommand => new Command(async () => await Shell.Current.GoToAsync("Login"));
}