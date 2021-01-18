using System;
using System.Collections.Generic;

namespace GeekBrainsSnake
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int yU, int yD, int x, char sym)
        {
            pList = new List<Point>();

            for (; yU <= yD; yU++)
            {
                Point p = new Point(x, yU, sym);
                pList.Add(p);
            }
        }

        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
