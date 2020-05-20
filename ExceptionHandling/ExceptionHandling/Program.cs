using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine(Divide(10,0));
            }
         
            catch 
            {
                Console.WriteLine("Opps!, something went wrong...");

            }
        }

        static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Argument must not be zero.", nameof(b));

            }
            return a / b;
        }
    }
}
