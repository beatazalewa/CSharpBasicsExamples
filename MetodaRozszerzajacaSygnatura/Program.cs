namespace MetodaRozszerzajacaSygnatura
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Pan Am";
            int n = s.CompareTo("KLM");    // Wywolanie oryginalnej metody CompareTo
            Console.WriteLine($"Result: {n}");
            Console.ReadLine();
        }
    }
}
/* Idea pisania metody rozszerzenia polega na stworzeniu metody, ktora moze zostac wywolana w taki sam sposob, jak jedna z metod instancji klasy. Nie mozna zastapic istniejacej metody instancji przy uzyciu metody rozszerzenia, ale dodawac tylko nowe metody.
*/
