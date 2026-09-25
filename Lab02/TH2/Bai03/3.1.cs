public class Student : IComparable<Student>
{
	public string Name { get; set; }
	public double Score { get; set; }

	public Student(string name, double score)
	{
		this.Name = name;
		this.Score = score;
	}

	public int CompareTo(Student? other)
	{
		if (other == null)
		{
			return 1;
		}

		return this.Score.CompareTo(other.Score);
	}

	public override string ToString()
	{
		return $"{this.Name}: {this.Score}";
	}
}

public class ArraySortExample
{
	public static void run()
	{
		Student[] students =
		{
			new Student("An", 8.5),
			new Student("Binh", 6.5),
			new Student("Chi", 9.0)
		};

		Array.Sort(students);

		foreach (Student student in students)
		{
			Console.WriteLine(student);
		}
	}
}