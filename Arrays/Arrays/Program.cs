using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bo", "li", "an"};


            //PrintFirst(names);
            //PrintLast(names);
            Array.Reverse(names);

            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i];
                Console.WriteLine($"{i+1} {name}");

            }

        }

        static void PrintFirst(string[] values)
        {
            Console.WriteLine(values[0]);
        }

        static void PrintLast(string[] values)
        {
            Console.WriteLine(values[values.Length -1]);
        }
    }
}
