using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Walls
    {
        List<Point> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Point>();

            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.AddRange(topLine.pList);
            wallList.AddRange(bottomLine.pList);
            wallList.AddRange(leftLine.pList);
            wallList.AddRange(rightLine.pList);
        }

        internal bool IsHit(Point p)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (Point p in wallList)
            {
                p.Draw();
            }
        }
    }

}
