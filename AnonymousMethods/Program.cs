using System;
using System.Collections.Generic;

namespace AnonymousMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person teacher = new Person();
            teacher.LastName = "Renoir";
            teacher.FirstName = "Candice";
            teacher.DateOfBirth = new DateTime(1987, 12, 20);
            people.Add(teacher);
            Person taxiDriver = new Person();
            taxiDriver.LastName = "Norris";
            taxiDriver.FirstName = "Chuck";
            taxiDriver.DateOfBirth = new DateTime(1973, 8, 5);
            people.Add(taxiDriver);
            Person singer = new Person();
            singer.LastName = "Jones";
            singer.FirstName = "Tom";
            singer.DateOfBirth = new DateTime(1966, 3, 15);
            people.Add(singer);
            people.Sort(delegate (Person p1, Person p2) { return Comparer<DateTime>.Default.Compare(p1.DateOfBirth, p2.DateOfBirth); });
            people.ForEach(delegate (Person p) { Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.DateOfBirth.ToShortDateString()); });
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string LastName = string.Empty;
        public string FirstName = string.Empty;
        public DateTime DateOfBirth;
        public Person()
        {
        }
    }
}
/* The first anonymous method is a custom sort for a person’s date of birth, and it sorts the collection of people by the DateOfBirth property: people.Sort(delegate(Person p1, Person p2) {return Comparer<DateTime>.Default.Compare(p1.DateOfBirth,p2.DateOfBirth);});
The second prints out the sorted collection of people using an anonymous method instead of a typical foreach loop.people.ForEach(delegate(Person p) { Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.DateOfBirth.ToShortDateString()); });
 */
