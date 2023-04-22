namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {

            var myAnonymousType = new
            {
                firstStringProperty = "First Property",
                secondIntegerProperty = 2,
                thirdBooleanProperty = true
            };
            /* myAnonymousType is an object of anonymous type created using the new keyword and object initializer syntax.
             It includes three properties of different data types. 
            */

            DoSomething(myAnonymousType);
            Console.ReadLine();
        }

        static void DoSomething(dynamic param)
        {
            Console.WriteLine(param.firstStringProperty);
        }
    }
}
