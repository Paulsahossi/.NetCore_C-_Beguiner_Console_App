using System;
namespace Types
{
    class Home
    {
        public Home(int numberOfwindows, string color)
        {
            NumberOfwindows = numberOfwindows;
            Color = color;
        }

        public int NumberOfwindows { get; set; }
        public String Color { get; set; }
    
    }
}
