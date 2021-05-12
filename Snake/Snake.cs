using System;
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
    }
}
