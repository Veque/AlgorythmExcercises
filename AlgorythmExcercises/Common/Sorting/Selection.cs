namespace Common.Sorting;

public static class Selection
{
    public static void SelectionSort<T>(this T[] array, Func<T, T, int> compare)
    {
        for (int i = 0; i < array.Length; i++)
        {
            var minIndex = -1;
            T minValue = default;
            for (int j = i; j < array.Length; j++)
            {
                if (minIndex == -1 || compare(minValue, array[j]) == 1)
                {
                    minIndex = j;
                    minValue = array[j];
                    continue;
                }
            }

            if (minIndex != i)
            {
                array.Swap(i, minIndex);
            }
        }
    }

    public static void SelectionSort<T>(this T[] array) where T : IComparable<T> =>
        SelectionSort(array, (t1, t2) => t1.CompareTo(t2));
}