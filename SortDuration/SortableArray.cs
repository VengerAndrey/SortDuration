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
        private int head_size;
        public int[] arr;
        private readonly Random r = new Random();

        public SortableArray(int size)
        {
            arr = new int[size];
            head_size = size;
        }

        public void FillRandomly()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(-1000, 1001);
            }
        }

        public long SortWithDuration(Action<int[]> sort)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            sort(arr);

            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }
    }
}
