using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point()
            {
                x = 5,
                y = 5,
                sym = '*'
            };
            point1.Drow();
        }
    }
}
