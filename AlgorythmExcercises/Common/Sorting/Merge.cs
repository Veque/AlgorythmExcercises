namespace Common.Sorting;

public static class Merge
{
    public static T[] MergeSort<T>(this T[] array, Func<T, T, int> compare)
    {
        var result = new T[array.Length];

        if (array.Length == 0)
        {
            return result;
        }

        Sort(array, result, compare, 0, array.Length - 1);
        
        return result;
    }

    public static void Sort<T>(T[] array, T[] result, Func<T, T, int> compare, int start, int end)
    {
        if (end - start == 0)
        {
            return;
        }

        if (end - start == 1)
        {
            if (compare(array[start], array[end]) == 1)
            {
                array.Swap(start, end);
            }

            return;
        }

        var middle = (start + end) / 2;

        Sort(array, result, compare, start, middle - 1);
        Sort(array, result, compare, middle, end);

        MergeArrays(array, result, compare, start, middle, end);
    }

    private static void MergeArrays<T>(T[] array, T[] result, Func<T, T, int> compare, int start, int middle, int end)
    {
        var first = start;
        var second = middle;
        for (int i = start; i <= end; i++)
        {
            if (first == middle)
            {
                result[i] = array[second];
                second += 1;
            }
            else if (second == end + 1)
            {
                result[i] = array[first];
                first += 1;
            }
            else
            {
                var firstItem = array[first];
                var secondItem = array[second];

                if (compare(firstItem, secondItem) == 1)
                {
                    result[i] = secondItem;
                    second += 1;
                }
                else
                {
                    result[i] = firstItem;
                    first += 1;
                }
            }
        }

        for (int i = start; i <= end; i++)
        {
            array[i] = result[i];
        }
    }
    
    public static T[] MergeSort<T>(this T[] array) where T : IComparable<T> =>
        MergeSort(array, (t1, t2) => t1.CompareTo(t2));
}