using System;
using System.Collections.Generic;

namespace GeekBrainsSnake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yU, int yD, int x, char sym)
        {
            pList = new List<Point>();

            for (; yU <= yD; yU++)
            {
                Point p = new Point(x, yU, sym);
                pList.Add(p);
            }
        }
    }
}
