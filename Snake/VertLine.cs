using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertLine
    {
        List<Point> pList;

        public VertLine(int yHigh, int yLow, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yHigh; y <= yLow; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (var item in pList)
            {
                item.Drow();
            }
        }
    }
}
