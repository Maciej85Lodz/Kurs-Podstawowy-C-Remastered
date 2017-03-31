﻿//using KursPodstawowyRemastered.Helpers;
//using KursPodstawowyRemastered.Klasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;

namespace KursPodstawowyRemastered
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Zmienne i ich typy

        #region Popularne typy zmiennych

        byte malaLiczba;                    // (1 bajt)     | od 0 do 255
        short liczbaCalkowitaKrotka;        // (2 bajty)    | od -32 768 do 32  767
        int liczbaCalkowita;                // (4 bajty)    | od -2 147 483 448 do 2 147 483 448
        long liczbaCalkowitaDluga;          // (8 bajtów)   | od -9 223 372 036 854 777 808 do -9 223 372 036 854 777 807
        float liczbaZmiennoprzecinkowa;     // (4 bajty)
        double liczbaZmiennoprzecinkowa2;   // (8 bajtów)
        bool prawdaFalsz;                   // (1 bajt)
        string tekst;
        object obiekt;                       // Przechowuje każdy obiekt

        #endregion

        #region Bardziej "zaawansowane" typy zmiennych

        //from GitHub (ImpactIT)
        char ZnakUnicode = 'Z';             // Reprezentuje jeden znak
        sbyte LiczbaCalkowita;
        Int16 LiczbaCalkowita16Bitowa;      // = short
        Int32 LiczbaCalkowita32Bitowa;      // = int
        Int64 LiczbaCalkowita64Bitowa;      // = long
        ushort liczbaCalkowitaKrotkaDodatnia;
        uint liczbaCalkowitaDodatnia;
        ulong liczbaCalkowitaDlugaDodatnia;

        #endregion

        #endregion

        #region Stale
        const float PI = 3.14f;
        const string naszeA = "aaaa";
        #endregion

        #region Zasieg Zmiennych

        public int zmiennaPubliczna = 1;
        internal int zmiennaInternal = 1;
        private int zmiennaPrywatna = 1;

        #endregion

        int liczbaPolubien = 10; // Testowa zmienna
        float r = 10f; // zmienaa pomocnicza
        #region Konstruktory Klasy
        // Bazowy Konstruktor klasy
        public MainWindow()
        {
            InitializeComponent();
            Instrukcje();
         }
        #endregion
        #region Instrukcje

        private void Instrukcje()
        {
            testowyTextBlock.Text = "Start";
            var warunek = false;

            //Printer Status
            var liczba = 150; // 0 = not working; 1= working; 2=maybe;

            //testowyTextBlock.Text = (warunek) ? "3" : "0";
            #region Instrukcja IF
            if (liczba > 1 && liczba < 100)
            {
                testowyTextBlock.Text = "True 1";
            }
            else if (liczba > 100 && liczba < 200)
            {
                testowyTextBlock.Text = "true 2";
            }
            else
            {
                testowyTextBlock.Text = "False";
            }
            #endregion

            #region Instrukcja Switch

            switch (liczba)
            {
                case 0:
                    testowyTextBlock.Text = "Printer is not working";
                    break;
                case 1:
                    testowyTextBlock.Text = "Printer is working";
                    break;
                case 2:
                    testowyTextBlock.Text = "Printer is working maybe";
                    break;

                default:
                    testowyTextBlock.Text = "UPS!!!!";
                    break;
            }
            #endregion

            #region Instrukcja FOR

            for (int i = 0; i < 10; i++)
            {
                testowyTextBlock.Text = i.ToString();   
            }
            #endregion
        }

        #endregion

        #region Metody Pomocnicze
        public void Operatory()
        {
            #region Zmienne pomocnicze

            int zmiennaLiczbowa1 = 10;
            int zmiennaLiczbowa2 = 20;

            bool zmiennaLogiczna1 = true;
            bool zmiennaLogiczna2 = false;

            #endregion

            // Operatory matematyczne
            var wynik1 = zmiennaLiczbowa1 + zmiennaLiczbowa2; // opeartor dodawania
            var wynik2 = zmiennaLiczbowa1 - zmiennaLiczbowa2; // opeartor różnicy (odejmowania)
            var wynik3 = zmiennaLiczbowa1 * zmiennaLiczbowa2; // opeartor mnożenia
            var wynik4 = zmiennaLiczbowa1 / zmiennaLiczbowa2; // opeartor dzielenia
            var wynik5 = zmiennaLiczbowa1 % zmiennaLiczbowa2; // opeartor dzielenia z resztą

            var wynik6 = zmiennaLiczbowa1++; // operator inkrementacji
            var wynik7 = zmiennaLiczbowa1--; // operator dekrementacji


            // Operatory relacji (najpopularniejsze)
            var wynik8 = (zmiennaLiczbowa1 == zmiennaLiczbowa2); // operator porównania
            var wynik9 = (zmiennaLiczbowa1 != zmiennaLiczbowa2); // operator negacji
            var wynik10 = (zmiennaLiczbowa1 > zmiennaLiczbowa2); // operator A większe od B (większości)
            var wynik11 = (zmiennaLiczbowa1 >= zmiennaLiczbowa2); // operator A większe lub równe B
            var wynik12 = (zmiennaLiczbowa1 < zmiennaLiczbowa2); // operator A mniejsze od B (mniejszości)
            var wynik13 = (zmiennaLiczbowa1 <= zmiennaLiczbowa2); // operator A mniejsze lub równe B

            // Operatory logiczne (najpopularniejsze)
            var wynik14 = (zmiennaLogiczna1 && zmiennaLogiczna2); // zwróci [true] gdy A i B mają wartośc true (suma logiczna)
            var wynik15 = (zmiennaLogiczna1 || zmiennaLogiczna2); // zwróci [true] gdy A lub B mają wartośc true (alternatywa logiczna)
            var wynik16 = (!zmiennaLogiczna1); // zwróci [true] A ma wartośc false (negacja logiczna)
            var wynik17 = (!zmiennaLogiczna1); // zwróci [true] A ma wartośc false (negacja logiczna)



            // Operatory matematyczne - sztuczki czyli skracanie zapisu
            zmiennaLiczbowa1 += 3; // skraca zapis => A = A + 3
            zmiennaLiczbowa1 = +3; // skraca zapis => A = 3 + A
            zmiennaLiczbowa1 = -3; // skraca zapis => A = 3 - A
            zmiennaLiczbowa1 *= 3; // skraca zapis => A = 3 * A
        }

        //Metoda
        public void PierwszaMetoda()
        {
            var wynik = PI * r * r;
            DrugaMetoda("aaaa");

            if (wynik > 30)
            {
                int klamrowaPulapka = 1;
            }
            //var wynik2 = PI + klamrowaPulapka; // BAD!!!


            var naszPierwszyVar = liczbaPolubien; // magicznyvar -1
        }
        /// <summary>
        /// This is the Test method which received always 'aaaa'
        /// </summary>
        /// <param name="a"> Super parameter 'aaaa'</param>

        public void DrugaMetoda(string a)
        {
            var naszDrugiVar = liczbaPolubien; // magiczny var -2
        }

        #endregion

       
    }
}
