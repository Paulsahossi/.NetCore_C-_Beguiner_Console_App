using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)

        {
            var (name, age) = GetPersonInfo();  
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
        static (string name, int age) GetPersonInfo()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int age = int.Parse(Console.ReadLine());

            return (name, age);
        }
        
    }
}
