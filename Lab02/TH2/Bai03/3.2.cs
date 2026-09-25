public class ArraySortSimulate
{
	public static void Sort<T>(T[] array) where T : IComparable<T>
	{
		for (int i = 0; i < array.Length - 1; i++)
		{
			for (int j = 0; j < array.Length - i - 1; j++)
			{
				if (array[j].CompareTo(array[j + 1]) > 0)
				{
					T temp = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temp;
				}
			}
		}
	}
}