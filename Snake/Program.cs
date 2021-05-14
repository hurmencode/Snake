using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontLine line = new HorizontLine(0, 78, 0, '+');
            HorizontLine line1 = new HorizontLine(0, 78, 24, '+');
            VertLine vertLine = new VertLine(0, 24, 0, '+');
            VertLine vertLine1 = new VertLine(0, 24, 78, '+');

            line.Drow();
            line1.Drow();
            vertLine.Drow();
            vertLine1.Drow();

            Point p = new Point(5, 4, '*');
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Drow();

            FoodCreate foodCreate = new FoodCreate(80, 25, '$');
            Point food = foodCreate.CraeteFood();
            food.Drow();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreate.CraeteFood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Controll(key.Key);
                }
            }

            //Console.ReadKey();
        }
    }
}
