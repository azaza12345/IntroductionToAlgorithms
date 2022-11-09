namespace SortingAndSearchAlgorithms
{
    public static class BinarySearch
    {
        public static int IterativeSolution(int[] array, int target)
        {
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == target)
                    return middle;

                if (array[middle] < target)
                    left = middle + 1;
                else
                    right = middle - 1;
            }

            return -1;
        }

        public static int RecursiveSolution(int[] array, int target)
        {
            var right = array.Length - 1;
            return Helper(array, target, 0, right);
        }

        private static int Helper(int[] array, int target, int left, int right)
        {
            if (left > right) return -1;
            var middle = (left + right) / 2;

            if (array[middle] == target)
                return middle;

            if (array[middle] < target)
                return Helper(array, target, middle + 1, right);
            else
                return Helper(array, target, left, middle - 1);
        }
    }
}