using System;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char sym;
         
        public Point(int xCord, int yCord, char symbol)
        {
            x = xCord;
            y = yCord;
            sym = symbol;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
         
    }
}
