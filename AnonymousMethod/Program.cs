using System;

namespace AnonymousMethod // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            Print print = delegate (int val) {
                Console.WriteLine($"Inside Anonymous method. Value: {val}");
            };
            print(100);
            Console.ReadLine();
        }
    }
}