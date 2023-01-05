using System;

namespace SortingAndSearchAlgorithms
{
    public static class SelectionSort
    {
        public static void Solution(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var indexOfSmallest = i;
                
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indexOfSmallest])
                    {
                        indexOfSmallest = j;
                    }
                }

                (array[i], array[indexOfSmallest]) = (array[indexOfSmallest], array[i]);
            }
        }
    }
}