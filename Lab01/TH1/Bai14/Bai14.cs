public class NhanVien
{
	private const decimal TienPhatMoiNgayVang = 100000m;

	public string HoTen { get; set; } = string.Empty;
	public decimal MucLuong { get; set; }
	public int SoNgayVang { get; set; }

	public decimal TinhLuong()
	{
		return MucLuong - SoNgayVang * TienPhatMoiNgayVang;
	}

	public void Nhap()
	{
		Console.Write("Nhap ho ten nhan vien: ");
		HoTen = Console.ReadLine() ?? string.Empty;
		Console.WriteLine($"Da nhap ho ten: {HoTen}");

		Console.Write("Nhap muc luong: ");

		decimal mucLuong; 

        while (!decimal.TryParse(Console.ReadLine(), out mucLuong))
        {
            Console.Write("Muc luong khong hop le. Nhap lai: ");
        }

        MucLuong = mucLuong; 
		Console.WriteLine($"Da nhap muc luong: {MucLuong}");

		Console.Write("Nhap so ngay vang: ");
		int soNgayVang;
		while (!int.TryParse(Console.ReadLine(), out soNgayVang))
		{
			Console.Write("So ngay vang khong hop le. Nhap lai: ");
		}

		SoNgayVang = soNgayVang;
		Console.WriteLine($"Da nhap so ngay vang: {SoNgayVang}");
	}

	public void Xuat()
	{
		Console.WriteLine($"Ho ten: {HoTen}");
		Console.WriteLine($"Muc luong: {MucLuong:N0} VNĐ");
		Console.WriteLine($"So ngay vang: {SoNgayVang}");
		Console.WriteLine($"Luong thuc nhan: {TinhLuong():N0} VNĐ");
	}
}
