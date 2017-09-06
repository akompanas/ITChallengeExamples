using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITChallenge
{
    public class Program5
    {
        public void Run()
        {
            if (!IsNotPossible())
                Console.WriteLine("These vertices make a triangle");
            else
                Console.WriteLine("Triangle cannot be made from these vertices");
       }

        private bool IsNotPossible()
        {
            var v = new Tuple<int, int>[] { Tuple.Create(0, 0), Tuple.Create(1, 0), Tuple.Create(1, 1) };
            var e = new List<float>();
            for (int i = 0; i < 3; i++)
            {
                e.Add((float)Math.Pow((v[i].Item1 - v[(i + 1) % 3].Item1) * (v[i].Item1 - v[(i + 1) % 3].Item1) + (v[i].Item2 - v[(i + 1) % 3].Item2) * (v[i].Item2 - v[(i + 1) % 3].Item2), 0.5));
            }
            e.Sort((a, b) => b.CompareTo(a)); // biggest first
            return e[0] >= e[1] + e[2];
        }
    }
}
