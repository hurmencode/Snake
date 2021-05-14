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

            Wall walls = new Wall(80, 25);
            walls.Drow();

            Point p = new Point(5, 4, '*');
            Snake snake = new Snake(p, 5, Direction.Right);
            snake.Drow();

            FoodCreate foodCreate = new FoodCreate(80, 25, '$');
            Point food = foodCreate.CraeteFood();
            food.Drow();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
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

            Console.Clear();
            Console.WriteLine("Конец игры!!!!\nНажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
