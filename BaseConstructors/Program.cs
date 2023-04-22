namespace BaseConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee coffee1 = new Coffee();
            Coffee coffee2 = new Coffee("Fourth Espresso", true, 170, "Arabica", "Dark", "Columbia");

            Console.WriteLine("*** Coffee 1 ***");
            Console.WriteLine($"Name: {coffee1.Name}");
            Console.WriteLine($"Fair Trade: { coffee1.IsFairTrade}");
            Console.WriteLine($"Serving Temperature: { coffee1.GetServingTemperature()}");
            Console.WriteLine($"Bean Type: {coffee1.Bean}");
            Console.WriteLine($"Roast Type: {coffee1.Roast}");
            Console.WriteLine($"Country of Origin: { coffee1.CountryOfOrigin}");
            Console.WriteLine();

            Console.WriteLine("*** Coffee 2 ***");
            Console.WriteLine($"Name: {coffee2.Name}");
            Console.WriteLine($"Fair Trade: {coffee2.IsFairTrade}");
            Console.WriteLine($"Serving Temperature: {coffee2.GetServingTemperature()}");
            Console.WriteLine($"Bean Type: {coffee2.Bean}");
            Console.WriteLine($"Roast Type: {coffee2.Roast}");
            Console.WriteLine($"Country of Origin: {coffee2.CountryOfOrigin}");
            Console.WriteLine();

            Espresso espresso1 = new Espresso();
            Espresso espresso2 = new Espresso("Italian Espresso", true, 170, "Arabica", "Super dark", "Columbia", "Royal Doulton", 100);

            Console.WriteLine("*** Espresso 1 ***");
            Console.WriteLine($"Serving Temperature: {espresso1.GetServingTemperature()}");
            Console.WriteLine($"Bean Type: {espresso1.Bean}");
            Console.WriteLine($"Roast Type: {espresso1.Roast}");
            Console.WriteLine($"Country of Origin: {espresso1.CountryOfOrigin}");
            Console.WriteLine($"Cup: {espresso1.Cup}");
            Console.WriteLine($"Capacity: {espresso1.Capacity}");
            Console.WriteLine();

            Console.WriteLine("*** Espresso 2 ***");
            Console.WriteLine($"Name: {espresso2.Name}");
            Console.WriteLine($"Fair Trade: {espresso2.IsFairTrade}");
            Console.WriteLine($"Serving Temperature: {espresso2.GetServingTemperature()}");
            Console.WriteLine($"Bean Type: {espresso2.Bean}");
            Console.WriteLine($"Roast Type: {espresso2.Roast}");
            Console.WriteLine($"Country of Origin: {espresso2.CountryOfOrigin}");
            Console.WriteLine($"Cup: {espresso2.Cup}");
            Console.WriteLine($"Capacity: {espresso2.Capacity}");
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
    }
}
