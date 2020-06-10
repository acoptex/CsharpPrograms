using System;
using System.Collections.Generic;


namespace Snake
{
    class Figure
    {
        protected List<Point> pointsList;
        public void Draw()
        {
            foreach (Point p in pointsList)
            {
                Console.WriteLine(p);
            }

        }
    }
}
