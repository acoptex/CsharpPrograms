using System;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Draw(1, 3, '*');
            Draw(4, 5, '#');

            Console.ReadKey();
        }
        static void Draw(int x,int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
