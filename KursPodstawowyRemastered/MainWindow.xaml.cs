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



        #endregion

       
        // Konstruktor klasy
        public MainWindow()
        {
            InitializeComponent();

           
        }
        
        //Metoda
        public void PierwszaMetoda()
        {
            var naszPierwszyVar = 1;
        }
   
    }
}
