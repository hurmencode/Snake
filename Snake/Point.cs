﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {

        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int ofset, Direction direction)
        {
            if (direction == Direction.Right)
            {
                x = x + ofset;
            }
            else if (direction == Direction.Left)
            {
                x = x - ofset;
            }
            else if (direction == Direction.Up)
            {
                y = y + ofset;
            }
            else if (direction == Direction.Down)
            {
                y = y - ofset;
            }
        }

        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Drow();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
