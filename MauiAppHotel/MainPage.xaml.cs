namespace MauiAppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnHospedagem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.ContratacaoHospedagem());
        }

        private async void OnMinhasReservasClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.MinhasReservas());
        }


        private async void BtnSobre_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.Sobre());
        }
    }
}
