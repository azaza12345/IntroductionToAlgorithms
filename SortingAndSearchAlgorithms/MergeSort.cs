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

            var mid = start + (end - start) / 2;

            Helper(array, start, mid);
            Helper(array, mid + 1, end);

            Merge(array, start, mid, end);
        }

        private static void Merge(int[] array, int start, int mid, int end)
        {
            var n = mid - start + 1;
            var m = end - mid;

            var a1 = new int[n];
            var a2 = new int[m];

            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = array[start + i];
            }

            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = array[mid + i + 1];
            }

            var k = 0;
            var l = 0;
            var s = start;
            while (k < a1.Length && l < a2.Length)
            {
                if (a1[k] < a2[l])
                {
                    array[s] = a1[k];
                    k++;
                }
                else
                {
                    array[s] = a2[l];
                    l++;
                }
                
                s++;
            }

            while (k < a1.Length)
            {
                array[s] = a1[k];
                s++;
                k++;
            }
            
            while (l < a2.Length)
            {
                array[s] = a2[l];
                s++;
                l++;
            }
        }
    }
}