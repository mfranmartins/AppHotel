namespace MauiAppHotel.Models
{
    public class Suite
    {
        public string Nome { get; set; }
        public double ValorAdulto { get; set; }
        public double ValorCrianca { get; set; }

        public Suite(string nome, double valorAdulto, double valorCrianca)
        {
            Nome = nome;
            ValorAdulto = valorAdulto;
            ValorCrianca = valorCrianca;
        }

        public override string ToString()
        {
            return Nome; // mostra só o nome no Picker
        }
    }
}
