using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortNS;

namespace UnitTestQuickSort
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void TestReverseSortedArray()
        {
            QuickSort<int> qSort = new QuickSort<int>(6);
            
            qSort.QSort(new int[6] { 5, 4, 3, 2, 1, 0 }, 0, 5);

            var a = qSort.GetTArray();
            string s1 = "";
            for(int i = 0; i < 6; i++)
            {
                s1 += Convert.ToString(a[i]) + " ";
            }
           
            Assert.AreEqual("0 1 2 3 4 5 ", s1, null, "Failed");
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            QuickSort<int> qSort = new QuickSort<int>(0);
            int[] array = new int[0] { };

            qSort.QSort(new int[0] { }, 0, 0);

            var a = qSort.GetTArray();

            CollectionAssert.AreEqual(a, array, "Not empty");
        }

        [TestMethod]
        public void TestNegativeValues()
        {
            QuickSort<int> qSort = new QuickSort<int>(5);

            qSort.QSort(new int[5] { -3, -1, -7, -5, -2 }, 0, 4);

            var a = qSort.GetTArray();
            string s1 = "";
            for (int i = 0; i < 5; i++)
            {
                s1 += Convert.ToString(a[i]) + " ";
            }

            Assert.AreEqual("-7 -5 -3 -2 -1 ", s1, null, "Failed");
        }

        [TestMethod]
        public void TestStringValues()
        {
            QuickSort<string> qSort = new QuickSort<string>(5);

            qSort.QSort(new string[5] { "b", "s", "a", "k", "d" }, 0, 4);

            var a = qSort.GetTArray();
            string s1 = "";
            for (int i = 0; i < 5; i++)
            {
                s1 += Convert.ToString(a[i]) + " ";
            }

            Assert.AreEqual("a b d k s ", s1, null, "Failed");
        }
    }
}
