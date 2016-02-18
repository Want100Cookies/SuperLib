using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class BubbleSort
    {
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            T temp;

            for (int outer = arr.Length-1; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer-1; inner++)
                {
                    if (arr[inner].CompareTo(arr[inner + 1]) > 0) // CompareTo less than zero: preceeds, zero: same spot, more than zero: follows this object
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
            }
        }
    }
}
