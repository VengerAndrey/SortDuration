using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortDuration
{
    class SortableArray
    {
        public int[] Arr;
        private readonly Random r = new Random();

        public SortableArray(int size)
        {
            Arr = new int[size];
        }

        public void FillRandomly()
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = r.Next(-1000, 1001);
            }
        }

        public long SortWithDuration(Action<int[]> sort)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            sort(Arr);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }
    }
}
