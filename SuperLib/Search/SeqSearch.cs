using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperLib.Collections;

namespace SuperLib.Search
{
    public static class SeqSearch
    {
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
