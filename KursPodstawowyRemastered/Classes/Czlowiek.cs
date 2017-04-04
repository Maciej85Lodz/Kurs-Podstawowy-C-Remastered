using KursPodstawowyRemastered.Helpers;
using System;

namespace KursPodstawowyRemastered.Classes
{
    public class Czlowiek
    {
        public Czlowiek(string imie, Rasy rasa, DateTime dataUrodzenia)
        {
            Imie = imie;
            Rasa = rasa;
            DataUrodzenia = dataUrodzenia;
            Wiek = DateTime.Now.Year - DataUrodzenia.Year;
        }


        public string Imie { get; set; }
        public Rasy Rasa { get; set; }
        public DateTime DataUrodzenia { get; set; }

        public int Wiek { get;  }

        public string Login;
        public string Haslo;
        
        public string Zawod;
        public string Zamieszkanie;

        
    }
}
