using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ResumoReserva : ContentPage
{
    public ResumoReserva(Suite suite, int adultos, int criancas, double total)
    {
        InitializeComponent();

        lbl_quarto.Text = $"Suíte: {suite.Nome}";
        lbl_adultos.Text = $"Adultos: {adultos}";
        lbl_criancas.Text = $"Crianças: {criancas}";
        lbl_total.Text = $"Total: R$ {total:F2}";
    }

    private async void OnFinalizarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Reserva", "Reserva finalizada com sucesso!", "OK");

        // Volta para a página inicial
        await Navigation.PopToRootAsync();
    }
}
