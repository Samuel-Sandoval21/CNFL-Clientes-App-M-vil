using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFLAppMobile.Views;

public partial class RegistroPage : ContentPage
{
    public RegistroPage()
    {
        InitializeComponent();
    }

    // ===== REGISTRARSE =====
    private async void OnRegistrarseClicked(object? sender, EventArgs e)
    {
        string nombre = EntryNombre?.Text ?? "";
        string cedula = EntryCedula?.Text ?? "";
        string telefono = EntryTelefono?.Text ?? "";
        string correo = EntryCorreo?.Text ?? "";
        string usuario = EntryUsuario?.Text ?? "";
        string contrasena = EntryContrasena?.Text ?? "";
        string confirmar = EntryConfirmarContrasena?.Text ?? "";

        // Validaciones básicas
        if (string.IsNullOrWhiteSpace(nombre))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa tu nombre completo", "Aceptar");
            return;
        }

        if (string.IsNullOrWhiteSpace(cedula))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa tu cédula", "Aceptar");
            return;
        }

        if (string.IsNullOrWhiteSpace(telefono))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa tu teléfono", "Aceptar");
            return;
        }

        if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
        {
            await DisplayAlertAsync("Error", "Por favor ingresa un correo válido", "Aceptar");
            return;
        }

        if (string.IsNullOrWhiteSpace(usuario) || usuario.Length < 3)
        {
            await DisplayAlertAsync("Error", "El usuario debe tener al menos 3 caracteres", "Aceptar");
            return;
        }

        if (string.IsNullOrWhiteSpace(contrasena) || contrasena.Length < 6)
        {
            await DisplayAlertAsync("Error", "La contraseña debe tener al menos 6 caracteres", "Aceptar");
            return;
        }

        if (contrasena != confirmar)
        {
            await DisplayAlertAsync("Error", "Las contraseñas no coinciden", "Aceptar");
            return;
        }

        // Simulación de registro exitoso
        await DisplayAlertAsync("¡Registro exitoso!",
            $"Bienvenido {nombre}.\n\nTu usuario es: {usuario}\n\n" +
            "Ahora puedes iniciar sesión con tus credenciales.",
            "Aceptar");

        // Ir a Login
        await Shell.Current.GoToAsync("LoginPage");
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

    // ===== MOSTRAR/OCULTAR CONFIRMAR CONTRASEÑA =====
    private void OnToggleConfirmClicked(object? sender, EventArgs e)
    {
        if (EntryConfirmarContrasena != null)
        {
            EntryConfirmarContrasena.IsPassword = !EntryConfirmarContrasena.IsPassword;
            var btn = sender as Button;
            if (btn != null)
            {
                btn.Text = EntryConfirmarContrasena.IsPassword ? "👁️" : "🙈";
            }
        }
    }

    // ===== IR A LOGIN =====
    private async void OnLoginTapped(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginPage");
    }
}