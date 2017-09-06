using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITChallenge
{
    public class Program3
    {
        public void Run()
        {
            List<Point> values = ReadData();
            if (values.Count != 3)
            {
                Console.WriteLine("Triangle needs three vertices");
                return;
            }
            if (!IsNotPossible(values))
                Console.WriteLine("These vertices make a triangle");
            else
                Console.WriteLine("Triangle cannot be made from these vertices");
       }

        private bool IsNotPossible(List<Point> v)
        {
            var e = new List<float>();
            for (int i = 0; i < 3; i++)
            {
                int p1 = i;
                int p2 = (i + 1) % 3;
                e.Add(d(v[p1], v[p2]));
            }
            e.Sort((a, b) => b.CompareTo(a)); // biggest first
            return e[0] >= e[1] + e[2];
        }

        private float d(Point p1, Point p2)
        {
            return (float)Math.Pow((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y), 0.5);
        }

        private class Point
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        private List<Point> ReadData()
        {
            var vertices = new List<Point>();
            vertices.Add(new Point(0, 0));
            vertices.Add(new Point(1, 0));
            vertices.Add(new Point(1, 1));
            return vertices;
        }
    }
}
