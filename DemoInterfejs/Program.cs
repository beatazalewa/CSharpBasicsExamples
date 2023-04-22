using System.Security.Cryptography.X509Certificates;

namespace Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt { IPunkt.X = 4, Y = 5 }; //wywołanie konstruktora domyslnego
            Punkt p2 = new Punkt();
            p2.X = 40;
            p2.Y = 50;

            Console.WriteLine("Nowy punkt p1 to: {0} {1}", p1.X, p1.Y);
            Console.WriteLine("Nowy punkt p2 to: {0} {1}", p2.X, p2.Y);
            Console.WriteLine(p1.DajOpis());
            Console.WriteLine(p1.ReklamaPortaluRandkowego());
            Console.ReadKey();
        }
    }

    interface IPunkt
    {
        //Skladowymi interfejsu moga byc wlasciwosci i metody oraz zdarzenia i indeksatory
        //Nie podajemy dla nich modyfikatora dostepu

        int X { get; set; } //Wlaciwosc bez modyfikatora dostepu 
        int Y { get; set; } //Wlaciwosc bez modyfikatora dostepu 

        string DajOpis(); //Deklaracja metody - tylko sygnatura
    }

    public class Punkt : IPunkt
    {
        private int x;
        private int y;

        int IPunkt.X { get => x; set => value = x; }
        int IPunkt.Y { get => y; set => value = y; }

        string IPunkt.DajOpis() 
        {
            return String.Format($"Współrzędne {x}, {y}");
        }

        public string ReklamaPortaluRandkowego() //moja wlasna metoda
        {
            return "Zarejestruj się na edarling.pl";
        }
    }
}
