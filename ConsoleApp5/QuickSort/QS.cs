using ConsoleApp5.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5.QuickSort
{
    class QS
    {
        //public static void quickSort(int[] A, int left, int right)
        //{
        //    if (left > right || left < 0 || right < 0) return;

        //    int index = partition(A, left, right);

        //    if (index != -1)
        //    {
        //        quickSort(A, left, index - 1);
        //        quickSort(A, index + 1, right);
        //    }
        //}

        //private static int partition(int[] A, int left, int right)
        //{
        //    if (left > right) return -1;

        //    int end = left;

        //    int pivot = A[right];    // choose last one to pivot, easy to code
        //    for (int i = left; i < right; i++)
        //    {
        //        if (A[i] < pivot)
        //        {
        //            swap(A, i, end);
        //            end++;
        //        }
        //    }

        //    swap(A, end, right);

        //    return end;
        //}

        //private static void swap(int[] A, int left, int right)
        //{
        //    int tmp = A[left];
        //    A[left] = A[right];
        //    A[right] = tmp;
        //}

        /* This function takes last element as pivot, 
    places the pivot element at its correct 
    position in sorted array, and places all 
    smaller (smaller than pivot) to left of 
    pivot and all greater elements to right 
    of pivot */
        private static int Partition(IList<Product> product, int low, int high)
        {
            var pivot = product[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (string.Compare(product[j].Name, pivot.Name) <= 0)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    var temp = product[i];
                    product[i] = product[j];
                    product[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            var temp1 = product[i + 1];
            product[i + 1] = product[high];
            product[high] = temp1;

            return i + 1;
        }


        /* The main function that implements QuickSort() 
        arr[] --> Array to be sorted, 
        low --> Starting index, 
        high --> Ending index */
        public static void QuickSort(IList<Product> product, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partition(product, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(product, low, pi - 1);
                QuickSort(product, pi + 1, high);
            }
        }












    }
}
