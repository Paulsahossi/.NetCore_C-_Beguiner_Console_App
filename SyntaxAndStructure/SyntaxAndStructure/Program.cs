using System;

namespace SyntaxAndStructure
{
    class Program
    {
        static void Main(string [] args)
        {
            Foo("Pawlus");
            Foo("Sahossi");
        }
     
        static void Foo(string name)
        {
            Console.WriteLine("in Foo...");
            Console.WriteLine(name);

            //int j = 0;
            //int a = 13 / j;
                

        }
    }
}
