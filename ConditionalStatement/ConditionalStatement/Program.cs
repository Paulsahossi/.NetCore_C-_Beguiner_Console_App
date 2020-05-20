using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isYes = true;
            int age = 20;
            if (isYes || age > 30)
                Console.WriteLine("Yes");
            else if (!isYes)
                Console.WriteLine("!");

             else
            {
                Console.WriteLine("No");
            }


            switch (age)
            {
                case 10: Console.WriteLine("ten"); break;
                case 20: Console.WriteLine("twenty"); break;
                default: Console.WriteLine("anything else..."); break;

            }
        }
        

    } 
}
