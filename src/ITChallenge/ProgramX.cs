using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITChallenge
{
    public class Program5
    {
        public void Run() // run program
        {
            if (!IsNotPossible()) // check if it is not possible
                Console.WriteLine("These vertices make a triangle"); // write output message
            else // else for (!IsNotPossible())
                Console.WriteLine("Triangle cannot be made from these vertices"); // write other message
       }

        private bool IsNotPossible() // checks if it is possible to create triangle from different points on the 2D plane. points are entered in tuples of two 32 bit integers
        // if triangle is possible then it will return false and if not possible then will return true because true = !false
        {
            var v = new Tuple<int, int>[] { Tuple.Create(0, 0), Tuple.Create(1, 0), Tuple.Create(1, 1) }; // input list of tuples
            var e = new List<float>(); // create list of floats like the one above to store floating point numbers
            for (int i = 0; i < 3; i++)// iterate from 1 to 3 because it is faster than foreach
                // calculate stuff
                e.Add((float)Math.Pow((v[i].Item1 - v[(i + 1) % 3].Item1) * (v[i].Item1 - v[(i + 1) % 3].Item1) + (v[i].Item2 - v[(i + 1) % 3].Item2) * (v[i].Item2 - v[(i + 1) % 3].Item2), 0.5));
            e.Sort((a, b) => b.CompareTo(a)); // sort values by comparing a to b
            return e[0] >= e[1] + e[2]; // check if first element is bigger than 1 + 2
        }
    }
}
