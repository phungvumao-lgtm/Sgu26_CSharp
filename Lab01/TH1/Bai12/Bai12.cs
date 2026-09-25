public class Program12
{
	public static string ChuyenChuThuong(string input)
	{
		return input.ToLower();
	}

	public static string ChuyenChuHoa(string input)
	{
		return input.ToUpper();
	}

	public static int DemSoTu(string input)
	{
		return input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries).Length;
	}
}
