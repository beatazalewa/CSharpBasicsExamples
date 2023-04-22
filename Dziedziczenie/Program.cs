namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat();
            pr.UstawSzerokosc(4);
            pr.UstawWysokosc(5);

            Kwadrat kw = new Kwadrat();
            kw.UstawWysokosc(3);

            // Obliczenie powierzchni
            Console.WriteLine($"Powierzchnia prostokąta: {pr.ObliczPowierzchnie()}");
            Console.WriteLine($"Powierzchnia kwadratu: {kw.ObliczPowierzchnie()}");
            Console.ReadKey();

            // Wynik działania programu
            // Powierzchnia prostokata: 20
            // Powierzchnia kwadratu: 9
        }
    }

    // klasa bazowa
    class Ksztalt
    {
        // modyfikator dostepu protected
        // pola dostepne sa dla klasy bazowej oraz klas, której po niej dziedzicza
        // gdybysmy zastosowali modyfikator dostępu private
        // pole byloby dostepne tylko dla tej klasy
        protected int szerokosc;
        protected int wysokosc;

        public void UstawWysokosc(int w)
        {
            wysokosc = w;
        }
        public void UstawSzerokosc(int s)
        {
            szerokosc = s;
        }
    }

    // klasa pochodna
    class Prostokat : Ksztalt   // klasa Prostokat dziedziczy po klasie Ksztalt
    {
        public int ObliczPowierzchnie()
        {
            // mamy dostęp do pol z klasy bazowej
            return wysokosc * szerokosc;
        }
    }

    // klasa pochodna
    class Kwadrat : Ksztalt   // klasa Kwadrat dziedziczy po klasie Ksztalt
    {
        public int ObliczPowierzchnie()
        {
            // mamy dostęp do pol z klasy bazowej
            return wysokosc * wysokosc;
        }
    }
}