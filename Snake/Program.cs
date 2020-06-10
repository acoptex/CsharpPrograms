using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            //creating three points
            Point point1 = new Point(2, 3, '#');
            Point point2 = new Point(4, 9, '#');
            Point point3 = new Point(3, 4, '#');
            //creating horizontal line
            HorizontalLine lineHorizontal = new HorizontalLine(5,10,8,'+');
            //creating vertical line
            VerticalLine lineVertical = new VerticalLine(5,9,15,'*');
            
            Console.ReadKey();
        }
        
        
    }
}
