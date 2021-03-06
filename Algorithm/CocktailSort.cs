using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    public class CocktailSort<T>:AlgorithmBase<T> where T:IComparable
    {
        public CocktailSort(IEnumerable<T> items) : base(items) { }
        public CocktailSort() { }

        protected override void MakeSort()
        {            
            int left = 0;
            int right = Items.Count - 1;


            while (left < right)
            {
                var sc = SwopCount;
                    
                for(int i=left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        //ComparisonCount++;
                    }
                }
                right--;

                if (sc == SwopCount)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Compare(Items[i], Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                        //ComparisonCount++;
                    }
                }
                left++;

                if (sc == SwopCount)
                {
                    break;
                }
            }    
        }
    }
}
