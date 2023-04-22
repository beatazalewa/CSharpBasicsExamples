namespace DziedziczenieBazowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Blat tp = new Blat(4, 5);
            tp.WyswietInformacje();
            Console.ReadKey();

            // Wynik działania programu
            //Dlugosc: 4
            //Szerokosc: 5
            //Powierzchnia: 20
            //Koszt: 1000
        }
    }

    // klasa bazowa
    class Prostokat
    {
        protected int dlugosc;
        protected int szerokosc;

        public Prostokat(int d, int s)
        {
            dlugosc = d;
            szerokosc = s;
        }

        public int ObliczPowierzchnie()
        {
            return dlugosc * szerokosc;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Długość: {dlugosc}");
            Console.WriteLine($"Szerokość: {szerokosc}");
            Console.WriteLine($"Powierzchnia: {ObliczPowierzchnie()}");
        }
    }

    // klasa pochodna
    class Blat : Prostokat
    {
        // Slowo kluczowe base przy konstruktorze pozwala nam wywowolac konsturktor klasy bazowej
        // W tym momencie przekazalismy nasze parametry do konstruktora klasy bazowej
        public Blat(int d, int s) : base(d, s)
        {
        }

        public int Koszt()
        {
            int koszt;
            koszt = ObliczPowierzchnie() * 50;
            return koszt;
        }

        public void WyswietInformacje()
        {
            /* slowo kluczowe base pozwala nam odwolac sie do skladowych klasy bazowej
            dla kompilatora wazniejsze sa zmienne z klasy, w ktorej wlasnie jestesmy
            // za pomoca slowa kluczowego base wskazujemy jednoznacznie do ktorej skladowej chcemy się odwołlac. Dzieki  poniższemu wywolaniu w obecnej metodzie wywolamy
              rowniez metode z klasy bazowej - wyswietlona zostanie wieksza ilosc informacji */
            base.WyswietlInformacje();  // z klasy bazowej Prostokat
            Console.WriteLine($"Koszt: {Koszt()}");  // z klasy pochodnej Blat
        }

    }
}
