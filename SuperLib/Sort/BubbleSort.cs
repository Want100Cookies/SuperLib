using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class BubbleSort
    {
        /// <summary>
        /// Sort the array according to the bubble sort algorithm (not very smart)
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array of the generic type</param>
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            // pre define var to speed up loop
            T temp;

            // For every element starting at the end
            for (int outer = arr.Length-1; outer >= 1; outer--)
            {
                // from zero to outer 
                for (int inner = 0; inner <= outer-1; inner++)
                {
                    if (arr[inner].CompareTo(arr[inner + 1]) > 0) // CompareTo less than zero: preceeds, zero: same spot, more than zero: follows this object
                    {
                        // Swap
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }
            }
        }
    }
}
