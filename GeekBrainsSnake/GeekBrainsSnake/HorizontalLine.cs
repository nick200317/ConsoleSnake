using System;
using System.Collections.Generic;

namespace GeekBrainsSnake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xL, int xR, int y, char sym)
        {
            pList = new List<Point>();
            
            for(; xL <= xR; xL++)
            {
                Point p = new Point(xL, y, sym);
                pList.Add(p);
            }
        }
    }
}
