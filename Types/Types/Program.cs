using System;
using System.Text;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Home home = new Home(10, "Blue");
            //DoStuffToHome(home);

            //Console.WriteLine(home.NumberOfwindows);
            //Console.WriteLine(home.Color);

            StringBuilder s = new StringBuilder("test");
            for (int i = 0; i < 100; i++)
            {
                s.Append("!");
            }
            Console.WriteLine(s);

        }

        static void DoStuffToHome(Home home)
        {
            home.NumberOfwindows--;
            home.Color = "Red";
        }
    }
}
