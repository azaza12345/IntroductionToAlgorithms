namespace SortingAndSearchAlgorithms
{
    public static class MergeSort
    {
        public static void Solution(int[] array)
        {
            Helper(array, 0, array.Length - 1);
        }

        private static void Helper(int[] array, int start, int end)
        {
            if (start >= end) return;
            
            int mid = start + (end - start) / 2;
            
            Helper(array, start, mid);
            Helper(array, mid + 1, end);
            
            Merge(array, start, mid, end);
        }

        private static void Merge(int[] array, int start, int mid, int end)
        {
            var n = mid - start + 1;
            var m = end - mid;

            var arr1 = new int[n];
            var arr2 = new int[m];

            int i, j;
 
            for (i = 0; i < n; ++i)
                arr1[i] = array[start + i];
            for (j = 0; j < m; ++j)
                arr2[j] = array[mid + 1 + j];

            i = 0;
            j = 0;
            
            var k = start;
            while (i < n && j < m)
            {
                if (arr1[i] <= arr2[j])
                {
                    array[k] = arr1[i];
                    i++;
                }
                else
                {
                    array[k] = arr2[j];
                    j++;
                }

                k++;
            }

            while (i < n)
            {
                array[k] = arr1[i];
                i++;
                k++;
            }
            
            while (j < m)
            {
                array[k] = arr2[j];
                j++;
                k++;
            }
        }
    }
}