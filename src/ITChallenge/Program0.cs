using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITChallenge
{
    public class Program0
    {
        public void Run()
        {
            List<Point> vertices = ReadVertices();
            if (vertices.Count != 3)
            {
                Console.WriteLine("Triangle needs three vertices");
                return;
            }

            if (IsTriangle(vertices))
            {
                Console.WriteLine("These vertices make a triangle");
            }
            else
            {
                Console.WriteLine("Triangle cannot be made from these vertices");
            }
        }

        private bool IsTriangle(List<Point> vertices)
        {
            var edges = new List<float>();
            for (int i = 0; i < 3; i++)
            {
                int p1 = i;
                int p2 = (i + 1) % 3;
                edges.Add(GetDistance(vertices[p1], vertices[p2]));
            }

            edges.Sort((a, b) => b.CompareTo(a)); // biggest first

            return edges[0] < edges[1] + edges[2];
        }

        private float GetDistance(Point p1, Point p2)
        {
            return (float)Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
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

        private List<Point> ReadVertices()
        {
            var vertices = new List<Point>();

            vertices.Add(new Point(0, 0));
            vertices.Add(new Point(1, 0));
            vertices.Add(new Point(1, 1));

            return vertices;
        }
    }
}
