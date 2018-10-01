using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SortHelperLibrary;

namespace SortHelperLibraryTest
{
    [TestFixture]
    public class SortHelperTest
    {
        [TestCase]
        public void QuickSort_SimpleSort()
        {
            int[] array = new int[] { 10, 4, 2, 6, 3, 9, 1 };

            int[] expected = new int[] { 1, 2, 3, 4, 6, 9, 10 };

            SortHelper.QuickSort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [TestCase]
        public void MergeSort_SimpleSort()
        {
            int[] array = new int[] { 10, 4, 2, 6, 3, 9, 1 };

            int[] expected = new int[] { 1, 2, 3, 4, 6, 9, 10 };

            SortHelper.MergeSort(array, 0, array.Length - 1);

            Assert.AreEqual(expected, array);
        }

        [TestCase]
        public void QuickSort_ParticularSort()
        {
            int[] array = new int[] { 10, 4, 2, 6, 3, 9, 1 };

            int[] expected = new int[] { 10, 4, 2, 3, 6, 9, 1 };

            SortHelper.QuickSort(array, 2, array.Length - 2);

            Assert.AreEqual(expected, array);
        }

        [TestCase]
        public void MergeSort_ParticularSort()
        {
            int[] array = new int[] { 10, 4, 2, 6, 3, 9, 1 };

            int[] expected = new int[] { 10, 4, 2, 3, 6, 9, 1 };

            SortHelper.MergeSort(array, 2, array.Length - 2);

            Assert.AreEqual(expected, array);
        }
    }
}
