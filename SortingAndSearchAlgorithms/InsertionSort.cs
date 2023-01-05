using System;

namespace SortingAndSearchAlgorithms
{
    public static class InsertionSort
    {
        public static void Solution(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var current = array[i];
                int j;
                for (j = i - 1; j >= 0 && current < array[j]; j--)
                {
                    array[j + 1] = array[j];
                }

                array[j + 1] = current;
            }
        }
    }
}