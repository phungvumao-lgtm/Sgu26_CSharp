public class SinhVien
{
	public string MaSinhVien { get; set; } = string.Empty;
	public string HoTen { get; set; } = string.Empty;
	public string DiaChi { get; set; } = string.Empty;
	public int NamThu { get; set; }

	public void Nhap()
	{
		Console.Write("Nhap ma sinh vien: ");
		MaSinhVien = Console.ReadLine() ?? string.Empty;
		Console.WriteLine($"Da nhap ma sinh vien: {MaSinhVien}");

		Console.Write("Nhap ho ten: ");
		HoTen = Console.ReadLine() ?? string.Empty;
		Console.WriteLine($"Da nhap ho ten: {HoTen}");

		Console.Write("Nhap dia chi: ");
		DiaChi = Console.ReadLine() ?? string.Empty;
		Console.WriteLine($"Da nhap dia chi: {DiaChi}");

		Console.Write("Nhap sinh vien nam thu may: ");
		int namThu;
		while (!int.TryParse(Console.ReadLine(), out namThu))
		{
			Console.Write("Nam thu khong hop le. Nhap lai: ");
		}

		NamThu = namThu;
		Console.WriteLine($"Da nhap sinh vien nam thu: {NamThu}");
	}

	public void Xuat()
	{
		Console.WriteLine($"Ma sinh vien: {MaSinhVien}");
		Console.WriteLine($"Ho ten: {HoTen}");
		Console.WriteLine($"Dia chi: {DiaChi}");
		Console.WriteLine($"Sinh vien nam thu: {NamThu}");
	}
}
