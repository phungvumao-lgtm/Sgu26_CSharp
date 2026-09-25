public abstract class ThiSinh
{
	public string SoBaoDanh { get; }
	public string HoTen { get; }
	public double Bai1 { get; }
	public double Bai2 { get; }
	public double Bai3 { get; }

	protected ThiSinh(
		string soBaoDanh,
		string hoTen,
		double bai1,
		double bai2,
		double bai3)
	{
		SoBaoDanh = soBaoDanh;
		HoTen = hoTen;
		Bai1 = bai1;
		Bai2 = bai2;
		Bai3 = bai3;
	}

	protected double TongBaBaiLapTrinh()
	{
		return Bai1 + Bai2 + Bai3;
	}

	public abstract double TinhTongDiem();
}

public class ThiSinhChuyen : ThiSinh
{
	public double TiengAnh { get; }

	public ThiSinhChuyen(
		string soBaoDanh,
		string hoTen,
		double bai1,
		double bai2,
		double bai3,
		double tiengAnh)
		: base(soBaoDanh, hoTen, bai1, bai2, bai3)
	{
		TiengAnh = tiengAnh;
	}

	public override double TinhTongDiem()
	{
		double diemThuong = TiengAnh switch
		{
			>= 7 and <= 8 => 1,
			>= 9 and <= 10 => 2,
			_ => 0
		};

		return TongBaBaiLapTrinh() + diemThuong;
	}
}

public class ThiSinhSieuCup : ThiSinh
{
	public double Csdl { get; }

	public ThiSinhSieuCup(
		string soBaoDanh,
		string hoTen,
		double bai1,
		double bai2,
		double bai3,
		double csdl)
		: base(soBaoDanh, hoTen, bai1, bai2, bai3)
	{
		Csdl = csdl;
	}

	public override double TinhTongDiem()
	{
		return TongBaBaiLapTrinh() + Csdl;
	}
}
