using System;

namespace SortingAndSearchAlgorithms
{
    public static class SelectionSort
    {
        public static void Solution(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var smallestIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallestIndex])
                    {
                        smallestIndex = j;
                    }
                }

                (array[i], array[smallestIndex]) = (array[smallestIndex], array[i]);
            }
        }
    }
}