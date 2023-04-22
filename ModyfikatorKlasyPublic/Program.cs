﻿namespace ModyfikatorKlasyPublic
{
    class Program
    {
        // Tutaj dojdzie do wykonania kodu naszej klasy
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat();
            pr.wysokosc = 2;
            //pr.szerokosc = 139;
            pr.WyswietlInformacje();
            Console.ReadKey();
            // Wykonanie programu
            //Szerokosc: 3.5
            //Wysokosc: 4.5
            //Powierzchnia: 15.75
        }
    }
    class Prostokat
    {
        // pola klasy
        private double szerokosc = 65;
        public double wysokosc;
        public double ObliczPowierzchnie()
        {
            return szerokosc * wysokosc;
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Szerokość: {szerokosc}");
            Console.WriteLine($"Wysokość: {wysokosc}" );
            Console.WriteLine($"Powierzchnia: {ObliczPowierzchnie()}");
        }
    }
}

