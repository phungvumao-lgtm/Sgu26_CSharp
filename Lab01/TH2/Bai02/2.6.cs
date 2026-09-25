public class FractionList
{
	private Fraction[] fractions;

	public FractionList()
	{
		this.fractions = new Fraction[0];
	}

	public FractionList(int n)
	{
		if (n < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(n));
		}

		this.fractions = new Fraction[n];
		for (int i = 0; i < n; i++)
		{
			this.fractions[i] = new Fraction();
		}
	}

	public FractionList(FractionList other)
	{
		this.fractions = new Fraction[other.fractions.Length];
		for (int i = 0; i < this.fractions.Length; i++)
		{
			this.fractions[i] = new Fraction(other.fractions[i]);
		}
	}

	public Fraction this[int index]
	{
		get { return this.fractions[index]; }
		set { this.fractions[index] = value; }
	}

	public void Input()
	{
		for (int i = 0; i < this.fractions.Length; i++)
		{
			Console.Write($"Nhap tu so phan so thu {i}: ");
			long numerator = long.Parse(Console.ReadLine() ?? "0");
			Console.WriteLine($"Da nhap tu so: {numerator}");
			Console.Write($"Nhap mau so phan so thu {i}: ");
			long denominator = long.Parse(Console.ReadLine() ?? "1");
			Console.WriteLine($"Da nhap mau so: {denominator}");
			this.fractions[i] = new Fraction(numerator, denominator);
		}
	}

	public Fraction Sum()
	{
		Fraction result = new Fraction();
		foreach (Fraction fraction in this.fractions)
		{
			result += fraction;
		}

		return result;
	}

	public void Output()
	{
		Console.WriteLine(string.Join(" + ", this.fractions.Select(fraction => fraction.ToString())));
		Console.WriteLine("Tong = " + this.Sum());
	}
}
