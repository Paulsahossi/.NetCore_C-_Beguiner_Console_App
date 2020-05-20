using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(10);

            //person.Age = 5;
            //person.Age = -10;
           
            Console.WriteLine(person.Age);
        }
    }
}
