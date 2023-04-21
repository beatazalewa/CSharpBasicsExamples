using System;

namespace CSharpBasicsExamples // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public delegate void Print(int value);
        static void Main(string[] args)
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Anonymous method");
            Console.Write("Your option? ");
        }
    }
}
