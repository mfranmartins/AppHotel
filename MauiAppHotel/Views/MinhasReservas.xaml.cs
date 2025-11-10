using MauiAppHotel.Models;

namespace MauiAppHotel.Views;

public partial class MinhasReservas : ContentPage
{
    // Lista global de reservas
    public static List<Reserva> listaDeReservas = new List<Reserva>();

    public MinhasReservas()
    {
        InitializeComponent();

        AtualizarLista();
    }

    // Método para adicionar reserva de forma global
    public static void AdicionarReservaGlobal(Reserva reserva)
    {
        listaDeReservas.Add(reserva);
    }

    public void AtualizarLista()
    {
        lstReservas.ItemsSource = null;
        lstReservas.ItemsSource = listaDeReservas;
    }
}
