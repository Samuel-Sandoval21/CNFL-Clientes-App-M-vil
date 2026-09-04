using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFLAppMobile.Views;

public partial class InicioPage : ContentPage
{
    public InicioPage()
    {
        InitializeComponent();
    }

    // ===== EVENTO: Ver detalle de factura =====
    private async void OnVerDetalleClicked(object? sender, EventArgs e)
    {
        await DisplayAlertAsync("Detalle de Factura",
            "Factura #FACT-2026-001\n" +
            "Período: Agosto 2026\n" +
            "Monto: ₡18.450\n" +
            "Vencimiento: 28 de agosto de 2026\n" +
            "Estado: Pendiente",
            "Aceptar");
    }

    // ===== EVENTO: Pagar ahora =====
    private async void OnPagarAhoraClicked(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//PagosPage");
    }

    // ===== EVENTO: Cambiar período del gráfico =====
    private void OnPeriodoClicked(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;

        // Resetear todos los botones
        BtnPeriodo6M.BackgroundColor = Color.FromArgb("#EEF0F7");
        BtnPeriodo6M.TextColor = Color.FromArgb("#727A86");
        BtnPeriodo31D.BackgroundColor = Color.FromArgb("#EEF0F7");
        BtnPeriodo31D.TextColor = Color.FromArgb("#727A86");
        BtnPeriodoLecturas.BackgroundColor = Color.FromArgb("#EEF0F7");
        BtnPeriodoLecturas.TextColor = Color.FromArgb("#727A86");

        // Activar el botón clickeado
        button.BackgroundColor = Color.FromArgb("#1E23E6");
        button.TextColor = Colors.White;
    }
}