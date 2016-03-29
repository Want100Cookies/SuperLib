using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class SelectionSort
    {
        /// <summary>
        /// Sort an array according to the selection sort algorithm
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array of generic type</param>
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            // Predefine vars to speed up loop
            int min;
            T temp;

            // Loop over whole array
            for (int outer = 0; outer <= arr.Length-1; outer++)
            {
                min = outer;

                // for every element starting at current index
                for (int inner = outer + 1; inner <= arr.Length-1; inner++)
                {
                    // Compare the two
                    if (arr[inner].CompareTo(arr[min]) < 0) // CompareTo returns less than zero if the object is smaller
                    {
                        min = inner;
                    }
                }

                // Swap the minimum with outer
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
