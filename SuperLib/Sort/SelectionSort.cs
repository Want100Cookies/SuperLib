using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class SelectionSort
    {
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            int min;
            T temp;

            for (int outer = 0; outer <= arr.Length-1; outer++)
            {
                min = outer;

                for (int inner = outer + 1; inner <= arr.Length-1; inner++)
                {
                    if (arr[inner].CompareTo(arr[min]) < 0) // CompareTo returns less than zero if the object is smaller
                    {
                        min = inner;
                    }
                }

                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
