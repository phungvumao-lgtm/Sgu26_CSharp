public class Program15
{
	public static int[] NhapMang(int n)
	{
		int[] numbers = new int[n];

		for (int index = 0; index < numbers.Length; index++)
		{
			Console.Write($"Nhap phan tu [{index}]: ");
			while (!int.TryParse(Console.ReadLine(), out numbers[index]))
			{
				Console.Write("Gia tri khong hop le. Nhap lai: ");
			}
			Console.WriteLine($"Da nhap phan tu [{index}]: {numbers[index]}");
		}

		return numbers;
	}

	public static void XuatMang(int[] numbers)
	{
		Console.WriteLine(string.Join(" ", numbers));
	}

	public static int TimPhanTuLonNhat(int[] numbers)
	{
		return numbers.Max();
	}

	public static int TimPhanTuNhoNhat(int[] numbers)
	{
		return numbers.Min();
	}

	public static int[] LaySoNguyenTo(int[] numbers)
	{
		return numbers.Where(IsPrime).ToArray();
	}

	private static bool IsPrime(int number)
	{
		if (number < 2)
		{
			return false;
		}

		for (int divisor = 2; divisor * divisor <= number; divisor++)
		{
			if (number % divisor == 0)
			{
				return false;
			}
		}

		return true;
	}
}
