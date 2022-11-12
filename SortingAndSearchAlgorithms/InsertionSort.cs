using System;

namespace SortingAndSearchAlgorithms
{
    public static class InsertionSort
    {
        public static void Solution(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                var num = array[i];
                var j = i - 1;

                while (j >= 0 && array[j] > num)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = num;
            }
        }
    }
}