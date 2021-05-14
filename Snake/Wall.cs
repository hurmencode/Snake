using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Wall
    {
        List<Figure> listWalls;

        public Wall(int mapWidth, int mapHeight)
        {
            listWalls = new List<Figure>();

            HorizontLine line = new HorizontLine(0, mapWidth - 2, 0, '+');
            HorizontLine line1 = new HorizontLine(0, mapWidth - 2, mapHeight - 1, '+');
            VertLine vertLine = new VertLine(0, mapHeight - 1, 0, '+');
            VertLine vertLine1 = new VertLine(0, mapHeight - 1, mapWidth - 2, '+');

            listWalls.Add(line);
            listWalls.Add(line1);
            listWalls.Add(vertLine);
            listWalls.Add(vertLine1);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in listWalls)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Drow()
        {
            foreach (var wall in listWalls)
            {
                wall.Drow();
            }
        }
    }
}
