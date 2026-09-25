public static class DelegateFunc
{
    public delegate int Compare<T>(T left, T right);

    public static void Sort<T>(T[] array, Compare<T> compare)
    {
        ArgumentNullException.ThrowIfNull(array);
        ArgumentNullException.ThrowIfNull(compare);

        for (int i = 0; i < array.Length - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare(array[j], array[j + 1]) > 0)
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
    }
}