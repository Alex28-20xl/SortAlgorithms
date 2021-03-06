using Algorithm.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class HeapSort<T>:AlgorithmBase<T>where T:IComparable
    {
        public HeapSort(IEnumerable<T> items) : base(items) { }
        public HeapSort() { }

        protected override void MakeSort()
        {
            var heap = new Heap<T>(Items);
            var sorted = heap.Order();
            Items = sorted;
        }
    }
}
