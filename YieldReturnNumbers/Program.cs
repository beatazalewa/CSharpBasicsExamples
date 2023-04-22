namespace YieldReturnNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] table = { 123, 435, 56, 2, 3, 5, 45, 56, 34, 43 };
            // displays 5 last numbers
            foreach (var number in LastNumbers(table, 5))
            {
                Console.Write($" {number} ,");
            }

            Console.ReadKey();
        }

        //displays x last numbers
        static IEnumerable<int> LastNumbers(int[] number, int lastNumbers)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (i >= number.Length - lastNumbers)
                {
                    yield return number[i];
                }
            }

        }
    }
}
