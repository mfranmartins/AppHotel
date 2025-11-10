using MauiAppHotel.Models;

namespace MauiAppHotel.Models
{
    public class Reserva
    {
        public Suite Suite { get; set; }
        public int Adultos { get; set; }
        public int Criancas { get; set; }
        public int Diarias { get; set; }
        public double Total { get; set; }

        public Reserva(Suite suite, int adultos, int criancas, int diarias, double total)
        {
            Suite = suite;
            Adultos = adultos;
            Criancas = criancas;
            Diarias = diarias;
            Total = total;
        }
    }
}
