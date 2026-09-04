using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace CNFLAppMobile.Views.Public;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(CedulaEntry.Text))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa tu cédula", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(PasswordEntry.Text))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa tu contraseña", "OK");
            return;
        }

        bool isAuthenticated = true;

        if (isAuthenticated)
        {
            await Shell.Current.GoToAsync("//Inicio");
        }
        else
        {
            await DisplayAlertAsync("Error", "Credenciales incorrectas", "OK");
        }
    }

    private async void OnFaceIdClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("Face ID", "Autenticación biométrica simulada", "OK");
        await Shell.Current.GoToAsync("//Inicio");
    }

    private async void OnWhatsAppClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("WhatsApp", "Conectando con el bot de WhatsApp...", "OK");
    }

    private async void OnSinpeClicked(object sender, EventArgs e)
    {
        await DisplayAlertAsync("SINPE", "Autenticación con SINPE Móvil", "OK");
        await Shell.Current.GoToAsync("//Inicio");
    }

    public ICommand NavigateToRegistroCommand => new Command(async () => await Shell.Current.GoToAsync("//Registro"));
    public ICommand NavigateToRecuperarCommand => new Command(async () => await Shell.Current.GoToAsync("//RecuperarClave"));
}