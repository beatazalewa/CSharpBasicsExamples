namespace YieldReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (char fib in Programmer("programista"))
                Console.Write(fib + " ");

            Console.ReadKey();
        }

        static IEnumerable<char> Programmer(string couplechars)
        {
            for (int i = 0; i < couplechars.Length; i++)
            {
                yield return couplechars[i];
            }
        }
    }
}

