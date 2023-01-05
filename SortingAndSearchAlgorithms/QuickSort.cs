using System.Runtime.InteropServices;

namespace SortingAndSearchAlgorithms
{
    public static class QuickSort
    {
        public static void Solution(int[] array)
        {
            Helper(array, 0, array.Length - 1);
        }

        private static void Helper(int[] array, int left, int right)
        {
            if (left >= right) return;
            
            var pivotIndex = GetPivotIndex(array, left, right);

            Helper(array, left, pivotIndex - 1);
            Helper(array, pivotIndex + 1, right);
        }

        private static int GetPivotIndex(int[] array, int left, int right)
        {
            var pivotIndex = left - 1;

            for (int i = left; i < right; i++)
            {
                if (array[i] < array[right])
                {
                    pivotIndex++;
                    Swap(ref array[i], ref array[pivotIndex]);
                }
            }

            pivotIndex++;
            Swap(ref array[pivotIndex], ref array[right]);

            return pivotIndex;
        }

        private static void Swap(ref int first, ref int second)
        {
            (first, second) = (second, first);
        }
    }
}