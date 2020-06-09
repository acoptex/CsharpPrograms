using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            //creating four objects
            Point point1 = new Point(2, 3, '*');
            Point point2 = new Point(4, 9, '#');
            Point point3 = new Point(1, 4, '%');
            Point point4 = new Point(6, 7, '?');

            //creating list with four objects
            List<Point> pointsList = new List<Point>();
            pointsList.Add(point1);
            pointsList.Add(point2);
            pointsList.Add(point3);
            pointsList.Add(point4);

            //created list of symbols
            List<char> symbolsList = new List<char>();
            symbolsList.Add('*');
            symbolsList.Add('#');
            symbolsList.Add('*');
            symbolsList.Add('#');
            
            foreach (char i in symbolsList)
            {
                Console.WriteLine(i);
            }            
            
            Console.ReadKey();
        }
        
    }
}
