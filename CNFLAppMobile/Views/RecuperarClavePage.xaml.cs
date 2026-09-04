using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFLAppMobile.Views;

public partial class RecuperarClavePage : ContentPage
{
    public RecuperarClavePage()
    {
        InitializeComponent();
    }

    // ===== ENVIAR ENLACE DE RECUPERACIÓN =====
    private async void OnEnviarClicked(object? sender, EventArgs e)
    {
        string correo = EntryCorreo?.Text ?? "";

        if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa un correo electrónico válido", "Aceptar");
            return;
        }

        await DisplayAlertAsync("Enlace enviado",
            $"Se ha enviado un enlace de recuperación a:\n\n{correo}\n\n" +
            "Revisa tu bandeja de entrada y sigue las instrucciones.",
            "Aceptar");

        // Volver a Login
        await Shell.Current.GoToAsync("LoginPage");
    }

    // ===== VOLVER A LOGIN =====
    private async void OnVolverLoginTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginPage");
    }
}