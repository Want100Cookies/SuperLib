using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class InsertionSort
    {
        /// <summary>
        /// Sort an array according to the insertino sort algorithm
        /// </summary>
        /// <typeparam name="T">generic type</typeparam>
        /// <param name="arr">array with generic type contents</param>
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            // Pre define vars to speed up loop
            int inner;
            T temp;

            // For every element, starting at the top
            for (int outer = 1; outer <= arr.Length-1; outer++)
            {
                // get the top and the top index
                temp = arr[outer];
                inner = outer;

                // while not at beginning and previous element is bigger
                while (inner > 0 && arr[inner - 1].CompareTo(temp) >= 0)
                {
                    // Move the element one to the right
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }

                // Set the missing element
                arr[inner] = temp;
            }
        }
    }
}
