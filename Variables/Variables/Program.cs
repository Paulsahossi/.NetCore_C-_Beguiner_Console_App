using System;

namespace Variables
{
    class Program
    {
        static int age = 30;
        static void Main(string[] args)
        {
            age = age + 1;
            age += 1;
            age++;
            Console.WriteLine(age);

            var name = "Pawlus";
            Console.WriteLine(name.ToUpper());

            Foot();



        }

        private static void Foot()
        {
            Console.WriteLine(age);
        }
    }
}
