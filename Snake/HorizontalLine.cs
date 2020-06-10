using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Snake
{
    
    class HorizontalLine
    {
        List<Point> pointsList;
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {

            pointsList = new List<Point>();
            for (int x=xLeft; x <= xRight; x++)
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
