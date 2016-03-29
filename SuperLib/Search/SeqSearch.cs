using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperLib.Collections;

namespace SuperLib.Search
{
    /// <summary>
    /// Sequential search compares every value one by one, stopping once the value is found.
    /// </summary>
    public static class SeqSearch
    {
        /// <summary>
        /// Find the first occurence of a value in arr
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns>index of value</returns>
        public static int FindFirst<T>(T[] arr, T value) where T : IComparable<T>
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Find last occurenc of value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <returns>index of value</returns>
        public static int FindLast<T>(T[] arr, T value) where T : IComparable<T>
        {
            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (arr[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        /// <summary>
        /// Find value in array as x'nth occurence
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <param name="value"></param>
        /// <param name="occurence"></param>
        /// <returns>index of value (at x'nth occurence)</returns>
        public static int Find<T>(T[] arr, T value, int occurence) where T : IComparable<T>
        {
            int noFound = 0;

            for (int i = arr.Length-1; i >= 0; i--)
            {
                if (!arr[i].Equals(value)) continue;

                noFound++;

                if (noFound == occurence)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
