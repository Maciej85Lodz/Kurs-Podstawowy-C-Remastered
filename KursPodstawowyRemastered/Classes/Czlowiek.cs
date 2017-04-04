using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPodstawowyRemastered.Classes
{
    public class Czlowiek
    {
        public string Imie { get; set; }
        public string Rasa { get; set; }
        public DateTime DataUrodzenia { get; set; }

        
        public string Login;
        public string Haslo;
        
        public string Zawod;
        public string Zamieszkanie;

        private int Wiek;
    }
}
