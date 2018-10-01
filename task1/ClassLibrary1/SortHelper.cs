using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortHelperLibrary
{
    public static class SortHelper
    {
        private static int FindQ(int[] array, int start, int end)
        {
            int x = array[end];
            int q = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] <= x)
                {
                    Swap(ref array[i], ref array[q]);

                    q++;
                }
            }

            Swap(ref array[q], ref array[end]);

            return q;
        }

        private static void Swap<T>(ref T firstItem, ref T secondItem)
        {
            T temp = firstItem;
            firstItem = secondItem;
            secondItem = temp;
        }

        public static void QuickSort(int[] array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (start < end)
            {
                int q = FindQ(array, start, end);
                QuickSort(array, start, q - 1);
                QuickSort(array, q + 1, end);

            }
        }

        private static void Merge(int[] array, int start, int middle, int end)
        {
            int[] tempArray = new int[array.Length];

            //for (int m = start; m <= end; m++)
            //{
            //    tempArray[m] = array[m];
            //}

            Array.Copy(array, tempArray, array.Length);

            int i = start;
            int j = middle + 1;
            int k = start;

            while (i <= middle && j <= end)
            {
                if (tempArray[i] <= tempArray[j])
                {
                    array[k] = tempArray[i];
                    i++;
                }
                else
                {
                    array[k] = tempArray[j];
                    j++;
                }
                k++;
            }
            while (i <= middle)
            {
                array[k] = tempArray[i];
                k++;
                i++;
            }
        }

        public static void MergeSort(int[] array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (start < end)
            {
                int q = (start + end) / 2;
                MergeSort(array, start, q);
                MergeSort(array, q + 1, end);

                Merge(array, start, q, end);
            }
        }


    }
}
