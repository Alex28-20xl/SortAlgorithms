using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for(int i = 0; i < 1000; i++)
            {
                Items.Add(rnd.Next(0, 100));
            }

            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            //arrage
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            //act
            bubble.Sort();

            //assert
            for(int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            //arrage
            var cocktail = new CocktailSort<int>();
            cocktail.Items.AddRange(Items);

            //act
            cocktail.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktail.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            //arrage
            var insert = new InsertSort<int>();
            insert.Items.AddRange(Items);

            //act
            insert.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);
            }
        }
    }
}
