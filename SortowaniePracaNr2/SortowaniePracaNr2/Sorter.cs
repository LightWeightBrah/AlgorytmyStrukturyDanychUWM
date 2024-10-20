using Accessibility;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

        public static int[] MergeSort(int[] array)
        {
            int length = array.Length;
            if (length <= 1)
                return array;

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int i = 0;
            int j = 0;

            for(; i < length; i++)
            {
                if(i < middle)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }
            MergeSort(leftArray);
            MergeSort(rightArray);
            Merge(leftArray, rightArray, array);

            return array;
        }

        public static int[] QuickSort(int[] array)
        {
            QuickSortLogic(array, 0, array.Length - 1);
            return array;
        }
        public static int[] CountingSort(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            int[] countingArray = new int[max + 1];
            
            for(int i = 0; i < array.Length; i++)
            {
                countingArray[array[i]]++;
            }

            for(int i = 1; i < countingArray.Length; i++)
            {
                countingArray[i] += countingArray[i - 1];
            }

            int[] sortedArray = new int[array.Length];

            for(int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[countingArray[array[i]] - 1] = array[i];
                countingArray[array[i]]--;
            }

            return sortedArray;
        }

        private static void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            
            int i = 0;
            int l = 0;
            int r = 0;

            while(l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++;
                }
                else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }

            while(l < leftSize)
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            while(r < rightSize)
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }

        }

        private static void QuickSortLogic(int[] array, int start, int end)
        {
            if (start >= end) 
                return;

            int pivot = Partition(array, start, end);
            QuickSortLogic(array, start, pivot - 1);
            QuickSortLogic(array, pivot + 1, end);
        }
        private static int Partition(int[] array, int start, int end)
        {

            int pivot = array[end];
            int i = start - 1;
            int temp;

            for (int j = start; j < end; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            i++;

            temp = array[i];
            array[i] = array[end];
            array[end] = temp;

            return i;
        }
    }
}
