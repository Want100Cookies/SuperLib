using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class SmartBubbleSort
    {
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            T temp;
            bool hasChanged;

            for (int outer = arr.Length - 1; outer >= 1; outer--)
            {
                hasChanged = false;
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner].CompareTo(arr[inner + 1]) <= 0) continue;

                    temp = arr[inner];
                    arr[inner] = arr[inner + 1];
                    arr[inner + 1] = temp;

                    hasChanged = true;
                }
                if (!hasChanged) return;
            }
        }
    }
}
