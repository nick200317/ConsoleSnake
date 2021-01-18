using System;
using System.Collections.Generic;

namespace GeekBrainsSnake
{
    class Figure
    {
        protected List<Point> pList;
        public void DrawLine()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
