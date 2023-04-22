using System.Security.Cryptography.X509Certificates;

namespace DemoInterfejs
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt { X = 4, Y = 5 }; //wywołanie konstruktora domyslnego
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
        //Składowymi interfejsu mogą być jedynie właściwości i metody (oraz zdarzenia i
        //indeksatory)
        //Nie podajemy dla nich modyfikatora dostępu

        int X { get; set; } //Właściwość bez modyfikatora dostępu public
        int Y { get; set; } //Właściwość bez modyfikatora dostępu public

        string DajOpis(); //Deklaracja metody - tylko sygnatura
    }

    public class Punkt : IPunkt
    {
        public int X { get; set; } //implementacja interfejsu - musi być public
        public int Y { get; set; } //implementacja interfejsu - musi być public

        public string DajOpis() //implementacja metody - musi być public
        {
            return String.Format("Współrzędne {0}, {1}", X, Y);
        }

        public string ReklamaPortaluRandkowego() //moja własna metoda
        {
            return "Zarejestruj się na edarling.pl";
        }
    }
}
