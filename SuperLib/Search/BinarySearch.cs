using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SuperLib.Collections;
using SuperLib.Sort;

namespace SuperLib.Search
{
    public static class BinarySearch
    {
        /// <summary>
        /// Search for the given value in the array
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="arr">The array to search in</param>
        /// <param name="value">The value to search for</param>
        /// <returns>Returns the index of the value in the array</returns>
        public static int Search<T>(this T[] arr, T value) where T : IComparable<T>
        {
            // Pre define vars to speed up loop
            int upperBound, lowerBound, mid;

            // Upperbound is end of array
            upperBound = arr.Length - 1;
            lowerBound = 0;

            // As long as the upperbound is larger then lowerbound there is somthing to search for
            while (lowerBound <= upperBound)
            {
                // Re calculate the mid (upper + lower) /2 (example. 2+6 = 8/2 = 4)
                mid = (upperBound + lowerBound)/2;

                // If equals, it is found
                if (arr[mid].Equals(value))
                {
                    return mid;
                }

                // Compare to (less then zero is smaller)
                if (value.CompareTo(arr[mid]) < 0)
                {
                    // Smaller, so set upperbound to mid minus one
                    upperBound = mid - 1;
                }
                else
                {
                    // Bigger, so set lowerbound to mid plus one
                    lowerBound = mid + 1;
                }
            }

            return -1; // Nothing found
        }
    }
}
