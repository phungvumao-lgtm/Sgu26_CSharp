public class Person
{
    private long id;
    private string name;
    private long yob;
    private long yod;

    public Person()
    {
        this.id = 0;
        this.name = string.Empty;
        this.yob = 0;
        this.yod = 0;
    }

    public Person(Person p)
    {
        this.id = p.id;
        this.name = p.name;
        this.yob = p.yob;
        this.yod = p.yod;
    }

    public void Input()
    {
        Console.Write("Nhap id: ");
        while (!long.TryParse(Console.ReadLine(), out this.id))
        {
            Console.Write("Id khong hop le. Nhap lai: ");
        }
        Console.WriteLine($"Da nhap id: {this.id}");

        Console.Write("Nhap ho ten: ");
        this.name = Console.ReadLine() ?? string.Empty;
        Console.WriteLine($"Da nhap ho ten: {this.name}");

        Console.Write("Nhap nam sinh: ");
        while (!long.TryParse(Console.ReadLine(), out this.yob))
        {
            Console.Write("Nam sinh khong hop le. Nhap lai: ");
        }
        Console.WriteLine($"Da nhap nam sinh: {this.yob}");

        Console.Write("Nhap nam mat (0 neu con song): ");
        while (!long.TryParse(Console.ReadLine(), out this.yod))
        {
            Console.Write("Nam mat khong hop le. Nhap lai: ");
        }
        Console.WriteLine($"Da nhap nam mat: {this.yod}");
    }

    public void Output()
    {
        Console.WriteLine($"Id: {this.id}");
        Console.WriteLine($"Ho ten: {this.name}");
        Console.WriteLine($"Nam sinh: {this.yob}");
        Console.WriteLine($"Nam mat: {this.yod}");
    }

    public bool IsLiving()
    {
        return this.yod == 0;
    }
}