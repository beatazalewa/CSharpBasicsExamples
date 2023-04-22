namespace ModyfikatorPrivate
{
    class Program
    {
        // Tutaj dojdzie do wykonania kodu naszej klasy
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat();
            pr.PobierzDane();
            pr.WyswietlInformacje();
            Console.ReadKey();
        }
    }
    class Prostokat
    {
        // pola klasy
        private double szerokosc;
        private double wysokosc;
        public double ObliczPowierzchnie()
        {
            return szerokosc * wysokosc;
        }
        public void PobierzDane()
        {
            Console.WriteLine("Podaj szerokosc: ");
            szerokosc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokosc: ");
            wysokosc = Convert.ToDouble(Console.ReadLine());
        }
        public void WyswietlInformacje()
        {
            Console.WriteLine($"Szerokosc: {szerokosc}");
            Console.WriteLine($"Wysokosc: {wysokosc}");
            Console.WriteLine($"Powierzchnia: {ObliczPowierzchnie()}");
        }
    }
}


