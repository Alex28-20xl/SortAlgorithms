using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithm
{
    public class AlgorithmBase<T> where T:IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();

        public AlgorithmBase(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }
        public AlgorithmBase() { }

        protected void Swop(int positionA,int positionB)
        {
            if(positionA<Items.Count && positionB < Items.Count)
            {                
                SwopCount++;

                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;                
            }
        }

        public TimeSpan Sort()
        {
            var timer = new Stopwatch();
            SwopCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected virtual void MakeSort()
        {
            Items.Sort();
        }

        protected int Compare(T a, T b)
        {            
            ComparisonCount++;
            return a.CompareTo(b);
        }
    }
}
