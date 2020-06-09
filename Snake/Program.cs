using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point();
            Point p2 = new Point();
            p1.Draw(1, 3, '*');
            p2.Draw(4, 5, '#');
            
            Console.ReadKey();
        }
        
    }
}
