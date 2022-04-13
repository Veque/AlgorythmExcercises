namespace Common.Sorting;

public static class Bubble
{
    public static void BubbleSort<T>(this T[] array, Func<T, T, int> compare)
    {
        var swapOccured = true;
        while (swapOccured)
        {
            swapOccured = false;
            for (int i = 0; i < array.Length-1; i++)
            {
                var item1 = array[i];
                var item2 = array[i + 1];
                if (compare(item1, item2) == 1)
                {
                    array.Swap(i, i+1);
                    swapOccured = true;
                }
            }
        }
        
    }
    
    public static void BubbleSort<T>(this T[] array) where T : IComparable<T> =>
        BubbleSort(array, (t1, t2) => t1.CompareTo(t2));
}