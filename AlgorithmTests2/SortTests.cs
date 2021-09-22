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
            for(int i = 0; i < 10000; i++)
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

        [TestMethod()]
        public void ShellSortTest()
        {
            //arrage
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            //act
            shell.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);
            }
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            //arrage
            var bases = new AlgorithmBase<int>();
            bases.Items.AddRange(Items);

            //act
            bases.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bases.Items[i]);
            }
        }

        [TestMethod()]
        public void TreeSortTest()
        {
            //arrage
            var tree = new TreeSort<int>();
            tree.Items.AddRange(Items);

            //act
            tree.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], tree.Items[i]);
            }
        }

        [TestMethod()]
        public void HeapSortTest()
        {
            //arrage
            var heap = new HeapSort<int>();
            heap.Items.AddRange(Items);

            //act
            heap.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heap.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            //arrage
            var selection = new SelectionSort<int>();
            selection.Items.AddRange(Items);

            //act
            selection.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selection.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            //arrage
            var gnome = new GnomeSort<int>();
            gnome.Items.AddRange(Items);

            //act
            gnome.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnome.Items[i]);
            }
        }

        [TestMethod()]
        public void LsdRedixSortTest()
        {
            //arrage
            var lsdRedix = new LsdRedixSort<int>();
            lsdRedix.Items.AddRange(Items);

            //act
            lsdRedix.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], lsdRedix.Items[i]);
            }
        }

        [TestMethod()]
        public void MsdRedixSortTest()
        {
            //arrage
            var msdRedix = new MsdRedixSort<int>();
            msdRedix.Items.AddRange(Items);

            //act
            msdRedix.Sort();

            //assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], msdRedix.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            // arrange
            var merge = new MergeSort<int>();
            merge.Items.AddRange(Items);

            // act
            merge.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], merge.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            // arrange
            var quick = new QuickSort<int>();
            quick.Items.AddRange(Items);

            // act
            quick.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quick.Items[i]);
            }
        }
    }
}
