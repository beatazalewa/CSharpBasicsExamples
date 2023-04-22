namespace KonstruktorParametryzowany
{
    class Program
    {
        static void Main(string[] args)
        {
            string? marka = "";
            string? model = "";
            Console.WriteLine("Podaj markę samochodu: ");
            marka = Console.ReadLine();
            Console.WriteLine("Podaj model samochodu: ");
            model = Console.ReadLine();
            if (model == "")
            {
                KonstruktorParametryzowany kp = new KonstruktorParametryzowany(marka);
            }
            if (model != "" && marka != "")
            {
                KonstruktorParametryzowany kp2 = new KonstruktorParametryzowany(marka, model); 
                
            }
            else
            {
                KonstruktorParametryzowany kp3 = new KonstruktorParametryzowany();
            }          
            Console.ReadKey();
        }
    }
    class KonstruktorParametryzowany
    {
        private string marka;
        private string model;

        public KonstruktorParametryzowany()
        {
            marka = "BMW";
            model = "X3";
            Console.WriteLine($"Marka podana przez użytkownika to: {marka} model: {model}");
        }
        public KonstruktorParametryzowany(string mk)
        {
            marka = mk;
            Console.WriteLine($"Marka podana przez użytkownika to: {marka}");
        }
        public KonstruktorParametryzowany(string mk, string ml)
        {
            marka = mk;
            model = ml;
            Console.WriteLine($"Marka podana przez użytkownika to: {marka} model: {model}");
        }
    }
}

