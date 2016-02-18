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
            int upperBound, lowerBound, mid;

            upperBound = arr.Length - 1;
            lowerBound = 0;

            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound)/2;

                if (arr[mid].Equals(value))
                {
                    return mid;
                }

                if (value.CompareTo(arr[mid]) < 0)
                {
                    upperBound = mid - 1;
                }
                else
                {
                    lowerBound = mid + 1;
                }
            }

            return -1;
        }
    }
}
