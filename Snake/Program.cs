using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontLine line = new HorizontLine(1, 9, 1, '*');
            line.Drow();

            VertLine vertLine = new VertLine(1, 5, 1, '*');
            vertLine.Drow();
        }
    }
}
