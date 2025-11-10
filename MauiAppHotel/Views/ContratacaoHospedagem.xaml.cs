using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    List<Suite> suites;

    public ContratacaoHospedagem()
    {
        InitializeComponent();

        // Criando a lista de suítes
        suites = new List<Suite>
        {
            new Suite("Suíte Luxo", 300, 150),
            new Suite("Suíte Master", 450, 200),
            new Suite("Suíte Standard", 200, 100)
        };

        // Atribuindo ao Picker
        pck_quarto.ItemsSource = suites;

        // Eventos para recalcular quando algo mudar
        stp_adultos.ValueChanged += RecalcularTotal;
        stp_criancas.ValueChanged += RecalcularTotal;
        pck_quarto.SelectedIndexChanged += RecalcularTotal;
        dtpck_checkin.DateSelected += RecalcularTotal;
        dtpck_checkout.DateSelected += RecalcularTotal;
    }

    private void RecalcularTotal(object sender, EventArgs e)
    {
        if (pck_quarto.SelectedItem is Suite suite)
        {
            // Calculando o número de diárias
            int diarias = 1;
            if (dtpck_checkin.Date < dtpck_checkout.Date)
            {
                diarias = (dtpck_checkout.Date - dtpck_checkin.Date).Days;
            }

            // Calculando o total
            double total = diarias * ((stp_adultos.Value * suite.ValorAdulto) +
                                       (stp_criancas.Value * suite.ValorCrianca));

            lbl_total.Text = $"Total: R$ {total:F2}";
        }
    }

    private void OnAvancarClicked(object sender, EventArgs e)
    {
        if (pck_quarto.SelectedItem is Suite suite)
        {
            int diarias = (dtpck_checkin.Date < dtpck_checkout.Date)
                          ? (dtpck_checkout.Date - dtpck_checkin.Date).Days
                          : 1;

            double total = diarias * ((stp_adultos.Value * suite.ValorAdulto) +
                                      (stp_criancas.Value * suite.ValorCrianca));

            // Adiciona a reserva na lista de MinhasReservas
            MinhasReservas.AdicionarReservaGlobal(new Reserva(
                suite,
                (int)stp_adultos.Value,
                (int)stp_criancas.Value,
                diarias,
                total
            ));

            // Navega para ResumoReserva
            Navigation.PushAsync(new ResumoReserva(suite, (int)stp_adultos.Value, (int)stp_criancas.Value, total));
        }
        else
        {
            DisplayAlert("Aviso", "Selecione uma suíte para continuar.", "OK");
        }
    }
}
