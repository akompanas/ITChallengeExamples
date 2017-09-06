using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITChallenge
{
    public class Program4
    {
        public void Run()
        {
            Tuple<int, int>[] values = ReadData();
            if (values.Length != 3)
            {
                Console.WriteLine("Triangle needs three vertices");
                return;
            }
            if (!IsNotPossible(values))
                Console.WriteLine("These vertices make a triangle");
            else
                Console.WriteLine("Triangle cannot be made from these vertices");
       }

        private bool IsNotPossible(Tuple<int,int>[] v)
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

        private float d(Tuple<int,int> p1, Tuple<int,int> p2)
        {
            return (float)Math.Pow((p1.Item1 - p2.Item1) * (p1.Item1 - p2.Item1) + (p1.Item2 - p2.Item2) * (p1.Item2 - p2.Item2), 0.5);
        }

        private Tuple<int,int>[] ReadData()
        {
            return new Tuple<int, int>[] {
                Tuple.Create(0, 0),
                Tuple.Create(1, 0),
                Tuple.Create(1, 1)
            };
        }
    }
}
