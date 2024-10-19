using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowaniePracaNr2
{
    public static class Sorter
    {
        public static int[] BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while(j > 0 && array[j - 1] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;

                    j--;
                }

            }

            return array;
        }

        public static int[] CountingSort(int[] arrayToSort)
        {
            throw new NotImplementedException();
        }

        public static int[] MergeSort(int[] arrayToSort)
        {
            throw new NotImplementedException();
        }

        public static int[] QuickSort(int[] arrayToSort)
        {
            throw new NotImplementedException();
        }
    }
}
