using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class SmartBubbleSort
    {
        /// <summary>
        /// Sort the array according to the smart bubble sort algorithm
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array of generic type</param>
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            // Predefine vars to speed up loop
            T temp;
            bool hasChanged;

            for (int outer = arr.Length - 1; outer >= 1; outer--)
            {
                // Nothing has yet changed
                hasChanged = false;
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    // If smaller or equal, do nothing
                    if (arr[inner].CompareTo(arr[inner + 1]) <= 0) continue;

                    // Else swap
                    temp = arr[inner];
                    arr[inner] = arr[inner + 1];
                    arr[inner + 1] = temp;

                    // And something has changed
                    hasChanged = true;
                }
                
                // Nothing has changed so stop the function
                if (!hasChanged) return;
            }
        }
    }
}
