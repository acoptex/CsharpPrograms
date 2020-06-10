using System;
using System.Collections.Generic;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pointsList;
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {       
            pointsList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pointsList.Add(p);               
            }
        }
        public void Draw()
        {
            foreach (Point p in pointsList)
            {
                Console.WriteLine(p);
            }

        }
    }
}
