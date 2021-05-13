﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int len, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < len; i++)
            {
                Point p = new (tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Drow();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void Controll(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow )
            {
                direction = Direction.Left;
            }
            else if (key == ConsoleKey.RightArrow )
            {
                direction = Direction.Right;
            }
            else if (key == ConsoleKey.UpArrow )
            {
                direction = Direction.Up;
            }
            else if (key == ConsoleKey.DownArrow )
            {
                direction = Direction.Down;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
