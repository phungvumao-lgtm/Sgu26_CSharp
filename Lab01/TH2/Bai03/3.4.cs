public class ConsoleMenu
{
	private readonly List<(string Name, Action<int> Action)> items = new();

	public void Add(string name, Action<int> action)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name);
		ArgumentNullException.ThrowIfNull(action);

		items.Add((name, action));
	}

	public void run(int data)
	{
		while (true)
		{
			Console.WriteLine("Menu");

			for (int i = 0; i < items.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {items[i].Name}");
			}

			Console.WriteLine("0. Thoat chuong trinh");
			Console.Write("Thuc hien: ");

			if (!int.TryParse(Console.ReadLine(), out int choice))
			{
				Console.WriteLine("Vui long nhap dung lua chon.");
				Console.WriteLine();
				continue;
			}

			Console.WriteLine($"Da nhap lua chon: {choice}");

			if (choice == 0)
			{
				return;
			}

			if (choice < 1 || choice > items.Count)
			{
				Console.WriteLine("Chuc nang khong ton tai.");
				Console.WriteLine();
				continue;
			}

			Console.WriteLine($"Ban thuc hien chuc nang {choice}");
			items[choice - 1].Action(data);
			Console.WriteLine();
		}
	}
}

public class PTBac2Console : ConsoleMenu
{
	private double a;
	private double b;
	private double c;
    public PTBac2Console()
    {
		Add("Nhap he so a, b, c", _ => NhapHeSo());
		Add("Giai phuong trinh ax^2 + bx + c = 0", _ => GiaiPhuongTrinh());
		Add("Xoa he so", _ => XoaHeSo());
	}

	private void NhapHeSo()
	{
		a = NhapSo("a");
		b = NhapSo("b");
		c = NhapSo("c");
		Console.WriteLine($"Da nhap: {a}x^2 + {b}x + {c} = 0");
	}

	private void GiaiPhuongTrinh()
	{
		if (a == 0)
        {
			Console.WriteLine("Day khong phai phuong trinh bac hai.");
			return;
		}

		double delta = b * b - 4 * a * c;

		if (delta > 0)
        {
			double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
			double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
			Console.WriteLine($"Delta > 0: x1 = {x1}, x2 = {x2}");
		}
		else if (delta == 0)
		{
			double x = -b / (2 * a);
			Console.WriteLine($"Delta = 0: nghiem kep x = {x}");
		}
		else
		{
			Console.WriteLine("Delta < 0: phuong trinh vo nghiem trong tap so thuc.");
		}
	}

	private void XoaHeSo()
	{
		a = 0;
		b = 0;
		c = 0;
		Console.WriteLine("Da xoa cac he so.");
	}

	private static double NhapSo(string tenHeSo)
	{
		while (true)
		{
			Console.Write($"Nhap {tenHeSo}: ");

			if (double.TryParse(Console.ReadLine(), out double value))
			{
				Console.WriteLine($"Da nhap {tenHeSo}: {value}");
				return value;
			}

			Console.WriteLine("Vui long nhap mot so hop le.");
		}
    }
}
