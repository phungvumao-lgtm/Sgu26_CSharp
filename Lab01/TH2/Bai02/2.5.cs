public class Polynomial
{
	private Monomial[] terms;

	public Polynomial()
	{
		this.terms = new Monomial[0];
	}

	public Polynomial(int degree)
	{
		if (degree < 0)
		{
			throw new ArgumentOutOfRangeException(nameof(degree));
		}

		this.terms = new Monomial[degree + 1];
		for (int i = 0; i < this.terms.Length; i++)
		{
			this.terms[i] = new Monomial();
		}
	}

	public Polynomial(Polynomial other)
	{
		this.terms = new Monomial[other.terms.Length];
		for (int i = 0; i < this.terms.Length; i++)
		{
			this.terms[i] = new Monomial(other.terms[i]);
		}
	}

	public int Length
	{
		get { return this.terms.Length; }
	}

	public Monomial this[int index]
	{
		get { return this.terms[index]; }
		set { this.terms[index] = value; }
	}

	public void Input()
	{
		for (int i = 0; i < this.terms.Length; i++)
		{
			Console.Write($"Nhap he so a{i}: ");
			double coefficient;
			while (!double.TryParse(Console.ReadLine(), out coefficient))
			{
				Console.Write("He so khong hop le. Nhap lai: ");
			}
			Console.WriteLine($"Da nhap he so a{i}: {coefficient}");

			this.terms[i] = new Monomial(coefficient, i);
		}
	}

	public void Output()
	{
		for (int i = 0; i < this.terms.Length; i++)
		{
			if (i > 0)
			{
				Console.Write(" + ");
			}

			Console.Write(this.terms[i]);
		}

		Console.WriteLine();
	}

	public double Evaluate(double x)
	{
		double result = 0;
		foreach (Monomial term in this.terms)
		{
			result += term.Evaluate(x);
		}

		return result;
	}
}
