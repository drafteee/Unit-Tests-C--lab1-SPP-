using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSortNS;

namespace UnitTestQuickSort
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]

        public void TestReverseSortedArray()
        {
            QuickSort qSort = new QuickSort(6);
            
            qSort.QSort(new int[6] { 5, 4, 3, 2, 1, 0 }, 0, 5);

            var a = qSort.GetArray();
            string s1 = "";
            for(int i = 0; i < 6; i++)
            {
                s1 += Convert.ToString(a[i]) + " ";
            }
           
            Assert.AreEqual("0 1 2 3 4 5 ", s1, null, "Failed");
        }
    }
}
