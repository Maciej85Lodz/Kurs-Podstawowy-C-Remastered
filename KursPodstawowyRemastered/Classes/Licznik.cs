using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursPodstawowyRemastered.Classes
{
    /// <summary>
    /// Klasa do wykonywania obliczeń programu
    /// </summary>
    public class Licznik
    {


        /// <summary>
        /// /Dodaje dwie liczby całkowite
        /// </summary>
        /// <param name="pierwsza">Pierwsza liczba</param>
        /// <param name="druga">Druga liczba</param>
        /// <returns></returns>
        public int DodajDwieLiczbyCalkowite(int pierwsza, int druga)
        {
            //Zabezpieczenie: kiedy ktos przekazal pusta wartosc
            if (pierwsza == null || druga == null)
                return 0;

            return pierwsza + druga;
        }
        /// <summary>
        /// Oblicza dowolna roznica czasu pomiedzy dzis a zadana data
        /// </summary>
        /// <param name="dataUrodzenia">Data</param>
        /// <returns></returns>
        public static int ObliczRoznicaDat(DateTime dataUrodzenia)
        {
            return DateTime.Now.Year - dataUrodzenia.Year;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataOd"></param>
        /// <param name="dataUrodzenia"></param>
        /// <returns></returns>
        public static int ObliczRoznicaDat(DateTime dataOd, DateTime dataUrodzenia)
        {
            return dataOd.Year - dataUrodzenia.Year;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rok"></param>
        /// <returns></returns>
        public static int ObliczRoznicaDat(int rok)
        {
            return DateTime.Now.Year - rok;
        }
    }
}
