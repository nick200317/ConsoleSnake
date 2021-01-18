using System;
using System.Collections.Generic;

namespace GeekBrainsSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            HorizontalLine hl = new HorizontalLine(5, 10, 8, '+');
            hl.DrawLine();

            Console.ReadLine();
        }
    }
}
