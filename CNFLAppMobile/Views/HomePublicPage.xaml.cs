using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFLAppMobile.Views;

public partial class HomePublicPage : ContentPage
{
    public HomePublicPage()
    {
        InitializeComponent();
    }

    // ===== IR A LOGIN =====
    private async void OnIniciarSesionClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("LoginPage");
    }

    // ===== IR A REGISTRO =====
    private async void OnRegistrarseClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("RegistroPage");
    }
}