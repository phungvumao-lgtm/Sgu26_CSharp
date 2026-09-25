public class Employee
{
	private const decimal PenaltyPerAbsentDay = 100000m;

	public string Name { get; set; } = string.Empty;
	public decimal Salary { get; set; }
	public int AbsentDays { get; set; }

	public void Input()
	{
		Console.Write("Nhap ho ten: ");
		this.Name = Console.ReadLine() ?? string.Empty;
		Console.WriteLine($"Da nhap ho ten: {this.Name}");

		Console.Write("Nhap muc luong: ");
		decimal salary;
		while (!decimal.TryParse(Console.ReadLine(), out salary))
		{
			Console.Write("Muc luong khong hop le. Nhap lai: ");
		}
		this.Salary = salary;
		Console.WriteLine($"Da nhap muc luong: {this.Salary}");

		Console.Write("Nhap so ngay vang: ");
		int absentDays;
		while (!int.TryParse(Console.ReadLine(), out absentDays) || absentDays < 0)
		{
			Console.Write("So ngay vang khong hop le. Nhap lai: ");
		}
		this.AbsentDays = absentDays;
		Console.WriteLine($"Da nhap so ngay vang: {this.AbsentDays}");
	}

	public decimal GetSalary()
	{
		return this.Salary - this.AbsentDays * PenaltyPerAbsentDay;
	}

	public void Output()
	{
		Console.WriteLine($"{this.Name}: {this.GetSalary():N0} VNĐ");
	}
}

public class Department
{
	private Employee[] employees;

	public Department()
	{
		this.employees = new Employee[0];
	}

	public Department(int n)
	{
		if (n < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(n));
		}

		this.employees = new Employee[n];
		for (int i = 0; i < n; i++)
		{
			this.employees[i] = new Employee();
		}
	}

	public void Input()
	{
		for (int i = 0; i < this.employees.Length; i++)
		{
			Console.WriteLine($"Nhan vien thu {i + 1}:");
			this.employees[i].Input();
		}
	}

	public decimal TotalSalary()
	{
		decimal total = 0;
		foreach (Employee employee in this.employees)
		{
			total += employee.GetSalary();
		}

		return total;
	}

	public void Output()
	{
		foreach (Employee employee in this.employees)
		{
			employee.Output();
		}

		Console.WriteLine($"Tong luong: {this.TotalSalary():N0} VNĐ");
	}
}
