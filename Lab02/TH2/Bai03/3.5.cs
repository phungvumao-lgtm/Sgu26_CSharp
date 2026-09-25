public abstract class NhanVien
{
	public string MaNhanVien { get; }
	public string HoTen { get; }
	public double LuongCoBan { get; }

	protected NhanVien(string maNhanVien, string hoTen, double luongCoBan)
	{
		MaNhanVien = maNhanVien;
		HoTen = hoTen;
		LuongCoBan = luongCoBan;
	}

	public abstract double TinhLuong();
}

public class NhanVienKinhDoanh : NhanVien
{
	public int SoHopDong { get; }

	public NhanVienKinhDoanh(
		string maNhanVien,
		string hoTen,
		double luongCoBan,
		int soHopDong)
		: base(maNhanVien, hoTen, luongCoBan)
	{
		SoHopDong = soHopDong;
	}

	public override double TinhLuong()
	{
		return LuongCoBan + SoHopDong * 500000;
	}
}

public class NhanVienSanXuat : NhanVien
{
	public int SoLuongSanPham { get; }

	public NhanVienSanXuat(
		string maNhanVien,
		string hoTen,
		int soLuongSanPham)
		: base(maNhanVien, hoTen, 0)
	{
		SoLuongSanPham = soLuongSanPham;
	}

	public override double TinhLuong()
	{
		double luong = SoLuongSanPham * 1000;

		if (SoLuongSanPham > 3000)
		{
			luong *= 1.05;
		}

		return luong;
	}
}