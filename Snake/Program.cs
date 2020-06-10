using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.SetBufferSize(80,25);
           
       
            //creating vertical lines
            VerticalLine leftLine = new VerticalLine(0, 23, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 23, 78, '+');
            //creating horizontal lines
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, 78, 23, '+');
           
            //creating three points
            Point point1 = new Point(2, 3, '#');
            Point point2 = new Point(4, 9, '#');
            Point point3 = new Point(3, 4, '#');
           Console.ReadKey();
        }


    }
}
