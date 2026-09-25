public class Program17
{
	public static int[,] SinhMang(int rows, int columns)
	{
		int[,] matrix = new int[rows, columns];

		for (int row = 0; row < rows; row++)
		{
			for (int column = 0; column < columns; column++)
			{
				matrix[row, column] = Random.Shared.Next(10, 101);
			}
		}

		return matrix;
	}

	public static void XuatMang(int[,] matrix)
	{
		for (int row = 0; row < matrix.GetLength(0); row++)
		{
			for (int column = 0; column < matrix.GetLength(1); column++)
			{
				Console.Write($"{matrix[row, column],4}");
			}

			Console.WriteLine();
		}
	}

	public static void TachChanLe(
		int[,] matrix,
		out int[] soChan,
		out int[] soLe)
	{
		List<int> evenNumbers = new();
		List<int> oddNumbers = new();

		foreach (int number in matrix)
		{
			if (number % 2 == 0)
			{
				evenNumbers.Add(number);
			}
			else
			{
				oddNumbers.Add(number);
			}
		}

		soChan = evenNumbers.ToArray();
		soLe = oddNumbers.ToArray();
	}
}
