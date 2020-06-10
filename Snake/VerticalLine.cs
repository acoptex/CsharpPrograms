using System;
using System.Collections.Generic;

namespace Snake
{
    class VerticalLine : Figure
    {
       
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pointsList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pointsList.Add(p);
            }
        }
     
    }
}