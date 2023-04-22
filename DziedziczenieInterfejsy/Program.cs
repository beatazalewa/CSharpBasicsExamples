
namespace DziedziczenieInterfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat(4, 5);
            Console.WriteLine(pr.WyswietDlugosc(pr.dlugosc));
            Console.WriteLine(pr.WyswietSzerokosc(pr.szerokosc));
            Console.WriteLine($"Koszt to: {pr.ObliczKoszt(25)}");

            Console.ReadKey();
            // Wynik dzialania programu
            //Dlugosc to: 4
            //Szerokosc to: 5
            //Koszt to: 500
        }
    }

    // klasa bazowa
    class Ksztalt
    {
        public int dlugosc;
        public int szerokosc;

        public Ksztalt(int d, int s)
        {
            dlugosc = d;
            szerokosc = s;
        }

        public int ObliczPowierzchnie()
        {
            return dlugosc * szerokosc;
        }
    }

    // definicja interfejsu
    // zawiera tylko szkielet metody
    public interface IObliczKoszt
    {
        int ObliczKoszt(int powierzchnia);
    }

    public interface IWyswietlInformacje
    {
        string WyswietDlugosc(int dlugosc);

        string WyswietSzerokosc(int szerokosc);
    }


    // klasa Prostokat dziedziczy po klasie Ksztalt i implementuje dwa interfejsy
    class Prostokat : Ksztalt, IObliczKoszt, IWyswietlInformacje
    {
        public Prostokat(int d, int s) : base(d, s)
        {
        }
        // implementacja metody z interfejsu IObliczKoszt
        public int ObliczKoszt(int p)
        {
            int koszt;
            koszt = p * ObliczPowierzchnie();
            return koszt;
        }

        // implementacja metod z interfejsu IWyswietlInformacje
        public string WyswietDlugosc(int dlugosc)
        {
            string info = String.Format($"Długość to: {dlugosc}");
            return info;
        }

        public string WyswietSzerokosc(int szerokosc)
        {
            string info = String.Format($"Szerokość to: {szerokosc}");
            return info;
        }
    }
}
