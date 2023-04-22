namespace Interfejs
{
	class Program
	{
		static void Main(string[] args)
		{
            Transakcje t1 = new Transakcje("01", "25/11/2022", 331);
            Transakcje t2 = new Transakcje("02", "26/11/2022", 3321);
            Transakcje t3 = new Transakcje();
            t1.WyswietlDane();
            t2.WyswietlDane();
            t3.WyswietlDane();
            Console.ReadKey();
            // Wynik działania programu
            //Kod: 01
            //Data: 25/11/2022
            //Ilosc: 331
            //Kod: 02
            //Data: 26/11/2022
            //Ilosc: 3321
        }
    }

	public interface ITransakcje
	{
		//skladowe interfejsu
		void WyswietlDane(); //metoda bez nawiadów klamrowych ({ otwiera już ciało metody) i bez modyfikatorow dostepu
		int PoliczIlosc();
	}

    /* - klasa IMPLEMENTUJE interfejs
    - ta klasa MUSI mieć zaimplementowane wszystkie skladowe z interfejsu
    - MOŻE też zawierac inne skladowe 
    - każdy może sobie taką klasę zaimplementować w dowolny sposób*/
    public class Transakcje : ITransakcje
    {
        private string kod;
        private string data;
        private int ilosc;
        public Transakcje()   //konstruktor domyślny
        {
            kod = "1234";
            data = "1/1/2023";
            ilosc = 3;
        }
        public Transakcje(string k, string d, int i)   //konstruktor parametryzowany
        {
            kod = k;
            data = d;
            ilosc = i;
        }
        public int PoliczIlosc()
        {
            return ilosc;
        }
        public void WyswietlDane()
        {
            Console.WriteLine($"Kod: {kod}");
            Console.WriteLine($"Data: {data}");
            Console.WriteLine($"Ilość: {ilosc}");
        }
    }
}
