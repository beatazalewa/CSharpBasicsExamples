namespace KlasaZKonstruktorem
{
    class Program
    {
        static void Main(string[] args)
        {
            // W momencie tworzenia nowego obiektu dojdzie do wywołania konstruktora
            KlasaZKonstruktorem kzk = new KlasaZKonstruktorem();

            Console.ReadKey();
        }
    }
    class KlasaZKonstruktorem
    {
        private string tekst;
        public KlasaZKonstruktorem()  //konstruktor domyślny
        {
            tekst = "Wywołanie konstruktora klasy";
            Console.WriteLine(tekst);
        }
    }
}
