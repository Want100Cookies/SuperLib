using System;
using SuperLib.Collections;

namespace SuperLib.Sort
{
    public static class InsertionSort
    {
        public static void Sort<T>(ref T[] arr) where T : IComparable<T>
        {
            int inner;
            T temp;

            for (int outer = 1; outer <= arr.Length-1; outer++)
            {
                temp = arr[outer];
                inner = outer;

                while (inner > 0 && arr[inner - 1].CompareTo(temp) >= 0)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }

                arr[inner] = temp;
            }
        }
    }
}
