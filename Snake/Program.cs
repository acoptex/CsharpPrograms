using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Point p1 = new Point(1,3,'*');
            Point p2 = new Point(4,5,'#');



            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            //numList.RemoveAt(0);
            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            
            Console.ReadKey();
        }
        
    }
}
