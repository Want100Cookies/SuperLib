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
