using System;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Bo");
            Person person2 = new Person("An");

            //person1.name = "Bo";
            person1.age = 30;

            //person1.name = "Li";
            person2.age = 40;

            Console.WriteLine(person1.name);
            Console.WriteLine(person1.age);


        }
    }
}
