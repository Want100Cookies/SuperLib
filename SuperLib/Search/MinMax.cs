using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperLib.Collections;

namespace SuperLib.Search
{
    public static class MinMax
    {
        /// <summary>
        /// Finds the minimum in the array by comparing every entry with the lowest found so far. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns>T value</returns>
        public static T FindMin<T>(T[] arr) where T : IComparable<T>
        {
            T min = arr[0];

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i].CompareTo(min) < 0)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Finds the maximum in the array by comparing every entry with the highest entry found so far
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arr"></param>
        /// <returns>T value</returns>
        public static T FindMax<T>(T[] arr) where T : IComparable<T>
        {
            T max = arr[0];

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i].CompareTo(max) > 0)
                {
                    max = arr[i];
                }
            }

            return max;
        }
    }
}
