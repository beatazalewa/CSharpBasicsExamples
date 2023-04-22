namespace PoleStatyczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //pole statyczne 
            KlasaZPolemStatycznym kps1 = new KlasaZPolemStatycznym();
            kps1.DodajPoleStatyczne();
            kps1.DodajPoleStatyczne();
            kps1.DodajPoleStatyczne();
            // Teraz utworzymy kolejny obiekt typu KlasaZPolemStatycznym
            KlasaZPolemStatycznym kps2 = new KlasaZPolemStatycznym();
            // Pamietajcie, że mamy tylko jedna kopie zmiennej statycznej
            kps2.DodajPoleStatyczne();
            kps2.DodajPoleStatyczne();
            kps2.DodajPoleStatyczne();
            kps2.DodajPoleStatyczne();
            Console.WriteLine($"Wartość liczby z pierwszego obiektu - klasa z polem statycznym: {kps1.WyswietlBiezacaWartoscPoleStatyczne()}");
            Console.WriteLine($"Wartość liczby z drugiego obiektu - klasa z polem statycznym: {kps2.WyswietlBiezacaWartoscPoleStatyczne()}");

            //pole instancji
            KlasaZPolem kp3 = new KlasaZPolem();
            kp3.Dodaj();
            kp3.Dodaj();
            kp3.Dodaj();

            KlasaZPolem kp4 = new KlasaZPolem();
            kp4.Dodaj();
            kp4.Dodaj();
            kp4.Dodaj();
            kp4.Dodaj();
            Console.WriteLine($"Wartość liczby z trzeciego obiektu - klasa z polem instancji: {kp3.WyswietlBiezacaWartosc()}");
            Console.WriteLine($"Wartość liczby z czwartego obiektu - klasa z polem instancji: {kp4.WyswietlBiezacaWartosc()}");
            Console.ReadKey();
            // Jeżeli wynik jest dla Ciebie zaskakujacy przeczytaj jeszcze raz
            // definicje składowych statycznych
            // Wynik działania programu
            //Wartosc liczby z pierwszego obiektu - klasa z polem statycznym: 7
            //Wartosc liczby z drugiego obiektu - klasa z polem statycznym: 7
            //Wartość liczby z trzeciego obiektu - klasa z polem instancji:
            //Wartość liczby z czwartego obiektu - klasa z polem instancji:
        }
    }
    class KlasaZPolemStatycznym
    {
        public static int liczba;   //pole statyczne
        public void DodajPoleStatyczne()
        {
            liczba++;
        }
        public int WyswietlBiezacaWartoscPoleStatyczne()
        {
            return liczba;
        }
    }

    class KlasaZPolem
    {
        public int liczba;   //pole instancji
        public void Dodaj()
        {
            liczba++;
        }
        public int WyswietlBiezacaWartosc()
        {
            return liczba;
        }
    }
}