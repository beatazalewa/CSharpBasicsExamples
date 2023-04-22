namespace MetodaStatyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaZMetodaStatyczna kms = new KlasaZMetodaStatyczna();  //utworzenie instancji klasy
            kms.Dodaj();   //na instancji klasy wywolujemy metode
            kms.Dodaj();
            kms.Dodaj();
            // Metoda statyczna jest dostępna bez tworzenia obiektu klasy
            Console.WriteLine($"Wartość liczby: {KlasaZMetodaStatyczna.MetodaStatycznaZwrocLiczbe()}");
            Console.ReadKey();
            // Wynik działania programu
            //Wartosc liczby: 3
        }
    }
    class KlasaZMetodaStatyczna
    {
        public static int liczba;
        public void Dodaj()   //metoda instancji klasy
        {
            liczba++;
        }
        public static int MetodaStatycznaZwrocLiczbe()  //metoda statyczna ma slowo static
        {
            return liczba;
        }
    }
}
