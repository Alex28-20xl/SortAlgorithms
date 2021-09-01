﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            //arrange
            var bubble = new BubbleSort<int>();

            var rnd = new Random();
            var items = new List<int>();

            for(int i = 0; i < 8000; i++)
            {
                items.Add(rnd.Next(0, 100));                
            }
            
            bubble.Items.AddRange(items);
            items.Sort();

            //act
            bubble.Sort();

            //assert
            for(int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);
            }            
        }
    }
}