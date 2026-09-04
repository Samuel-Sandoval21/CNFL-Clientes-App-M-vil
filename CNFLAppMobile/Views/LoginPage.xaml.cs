using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFLAppMobile.Views;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    // ===== INICIAR SESIÓN =====
    private async void OnIniciarSesionClicked(object? sender, EventArgs e)
    {
        string usuario = EntryUsuario?.Text ?? "";
        string contrasena = EntryContrasena?.Text ?? "";

        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa usuario y contraseña", "Aceptar");
            return;
        }

        // Simulación: credenciales válidas = "cliente" / "123456"
        if (usuario == "cliente" && contrasena == "123456")
        {
            await Shell.Current.GoToAsync("//InicioPage");
        }
        else
        {
            await DisplayAlertAsync("Error", "Usuario o contraseña incorrectos", "Aceptar");
        }
    }

    // ===== MOSTRAR/OCULTAR CONTRASEÑA =====
    private void OnTogglePasswordClicked(object? sender, EventArgs e)
    {
        if (EntryContrasena != null)
        {
            EntryContrasena.IsPassword = !EntryContrasena.IsPassword;
            var btn = sender as Button;
            if (btn != null)
            {
                btn.Text = EntryContrasena.IsPassword ? "👁️" : "🙈";
            }
        }
    }

    // ===== OLVIDASTE CONTRASEÑA =====
    private async void OnOlvidarClaveTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RecuperarClavePage");
    }

    // ===== REGISTRO =====
    private async void OnRegistroTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RegistroPage");
    }
}