namespace Common;

public static class Common
{
    public static void Swap<T>(this T[] array, int i1, int i2)
    {
        (array[i1], array[i2]) = (array[i2], array[i1]);
    }
}