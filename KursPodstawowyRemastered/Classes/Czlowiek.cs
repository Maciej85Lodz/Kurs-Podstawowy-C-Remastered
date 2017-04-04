using KursPodstawowyRemastered.Helpers;
using System;

namespace KursPodstawowyRemastered.Classes
{
    /// <summary>
    /// Klasa Czlowiek
    /// </summary>
    public class Czlowiek
    {

        #region Konstruktory


        /// <summary>
        /// Konstruktor klasy Czlowiek
        /// </summary>
        /// <param name="imie">Imie czleka</param>
        /// <param name="rasa">rasa czleka</param>
        /// <param name="dataUrodzenia">Data urodzenia czleka</param>
        public Czlowiek(string imie, Rasy rasa, DateTime dataUrodzenia)
        {
            Imie = imie;
            Rasa = rasa;
            DataUrodzenia = dataUrodzenia;
            Wiek = Licznik.ObliczRoznicaDat(DataUrodzenia);
            Haslo = "";
            Login = "No Login Here";

        }
        /// <summary>
        /// Konstruktor klasy Czlowiek
        /// </summary>
        /// <param name="imie"></param>
        /// <param name="rasa"></param>
        /// <param name="dataUrodzenia"></param>
        /// <param name="haslo"></param>
        public Czlowiek(string imie, Rasy rasa, DateTime dataUrodzenia, string haslo, string login)
        {
            Imie = imie;
            Rasa = rasa;
            DataUrodzenia = dataUrodzenia;
            Wiek = Licznik.ObliczRoznicaDat(DataUrodzenia);
            Haslo = haslo;
            Login = SprawdzLogin(login)? login : "Bad login";
        }



        #endregion

        #region Wlasciwosci


        /// <summary>
        /// Imie
        /// </summary>
        public string Imie { get; set; }
        /// <summary>
        /// Rasa
        /// </summary>
        public Rasy Rasa { get; set; }
        /// <summary>
        /// Data Urodzenia
        /// </summary>
        public DateTime DataUrodzenia { get; set; }
        /// <summary>
        /// Wiek (obliczany automatycznie)
        /// </summary>
        public int Wiek { get; }

        public string Login { get; set; }
        public string Haslo { get; set; }
        #endregion

        #region Do implementacji

        // Nie używane pola (dla testow)

        public string Zawod;
        public string Zamieszkanie;
        #endregion


        #region Metody
        /// <summary>
        /// Generuj haslo z GIUD
        /// </summary>
        /// <returns></returns>
        public string GenerujHaslo()
        {
           return Guid.NewGuid().ToString();
        }
        /// <summary>
        /// sprawdzanie dlugosci loginu
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        private bool SprawdzLogin(object login)
        {
            bool isCorrect = false;

            if (Login.Length > 7)
                isCorrect = true;

            return isCorrect;
            
        }
        #endregion

    }
}
