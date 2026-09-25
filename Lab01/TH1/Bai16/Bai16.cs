public class Program16
{
	public static string[] NhapDanhSachHoTen(int n)
	{
		string[] names = new string[n];

		for (int index = 0; index < names.Length; index++)
		{
			Console.Write($"Nhap ho ten [{index}]: ");
			names[index] = Console.ReadLine() ?? string.Empty;
			Console.WriteLine($"Da nhap ho ten [{index}]: {names[index]}");
		}

		return names;
	}

	public static void SapXepTangDan(string[] names)
	{
		Array.Sort(names, StringComparer.CurrentCultureIgnoreCase);
	}

	public static void XuatDanhSach(string[] names)
	{
		foreach (string name in names)
		{
			Console.WriteLine(name);
		}
	}
}
