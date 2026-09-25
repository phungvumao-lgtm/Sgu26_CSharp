public class Program{
    public static void Main(string[] args)
    {
        RunAll();
    }

    public static void RunAll()
    {
        RunBai1_1();
        RunBai1_2();
        RunBai1_3();
        RunBai1_4();
        RunBai1_5();
        RunBai2_1();
        RunBai2_2();
        RunBai2_3();
        RunBai2_4();
        RunBai2_5();
        RunBai2_6();
        RunBai2_7();
        RunBai3_1();
        RunBai3_2();
        RunBai3_3();
        RunBai3_4();
        RunBai3_5();
        RunBai3_6();
    }

    private static void RunBai1_1()
    {
        Console.WriteLine("\n--- Bai 1.1 ---");
        RunWithInput(Program1_1.run, "Nguyen Van An\n2005\n");
    }

    private static void RunBai1_2()
    {
        Console.WriteLine("\n--- Bai 1.2 ---");
        Point first = new(1, 2);
        Point second = new(4, 6);
        Point sum = first + second;
        Point midpoint = Point.mid(first, second);
        Console.Write("Tong hai diem: ");
        sum.Output();
        Console.WriteLine($"Khoang cach: {Point.dis(first, second):F2}");
        Console.Write("Trung diem: ");
        midpoint.Output();
    }

    private static void RunBai1_3()
    {
        Console.WriteLine("\n--- Bai 1.3 ---");
        Person person = new();
        RunWithInput(person.Input, "1\nTran Binh\n2004\n0\n");
        person.Output();
        Console.WriteLine($"Con song: {person.IsLiving()}");
    }

    private static void RunBai1_4()
    {
        Console.WriteLine("\n--- Bai 1.4 ---");
        Fraction first = new(1, 2);
        Fraction second = new(1, 3);
        Console.WriteLine($"{first} + {second} = {first + second}");
        Console.WriteLine($"{first} * {second} = {first * second}");
    }

    private static void RunBai1_5()
    {
        Console.WriteLine("\n--- Bai 1.5 ---");
        Monomial monomial = new(3, 2);
        Console.WriteLine($"Don thuc: {monomial}, Gia tri tai x = 2: {monomial.Evaluate(2)}");
        Console.WriteLine($"Dao ham: {monomial.Derivative()}");
    }

    private static void RunBai2_1()
    {
        Console.WriteLine("\n--- Bai 2.1 ---");
        ArrayPoint points = new();
        points.Add(new Point(1, 1));
        points.Add(new Point(2, 3));
        Console.WriteLine($"So diem: {points.Count}");
        points[0].Output();
        points[1].Output();
    }

    private static void RunBai2_2()
    {
        Console.WriteLine("\n--- Bai 2.2 ---");
        PersonList people = new();
        RunWithInput(people.Input, "2\n1\nLe An\n2003\n0\n2\nPham Chi\n2002\n2024\n");
        Console.WriteLine("Danh sach nguoi con song:");
        people.LivingPeople().Output();
    }

    private static void RunBai2_3()
    {
        Console.WriteLine("\n--- Bai 2.3 ---");
        IntegerArray numbers = new(5);
        int[] values = { 2, 7, 4, 9, 8 };
        for (int index = 0; index < values.Length; index++)
        {
            numbers[index] = values[index];
        }
        numbers.Output();
        Console.WriteLine("So chan: " + string.Join(" ", numbers.EvenNumbers()));
    }

    private static void RunBai2_4()
    {
        Console.WriteLine("\n--- Bai 2.4 ---");
        IntegerMatrix matrix = new(2, 3);
        int[,] values = { { 2, 7, 4 }, { 9, 8, 11 } };
        for (int row = 0; row < matrix.Rows; row++)
        {
            for (int column = 0; column < matrix.Columns; column++)
            {
                matrix[row, column] = values[row, column];
            }
        }
        matrix.Output();
        Console.WriteLine("So nguyen to: " + string.Join(" ", matrix.PrimeNumbers()));
    }

    private static void RunBai2_5()
    {
        Console.WriteLine("\n--- Bai 2.5 ---");
        Polynomial polynomial = new(2);
        polynomial[0] = new Monomial(1, 0);
        polynomial[1] = new Monomial(2, 1);
        polynomial[2] = new Monomial(3, 2);
        polynomial.Output();
        Console.WriteLine($"Gia tri tai x = 2: {polynomial.Evaluate(2)}");
    }

    private static void RunBai2_6()
    {
        Console.WriteLine("\n--- Bai 2.6 ---");
        FractionList fractions = new(3);
        fractions[0] = new Fraction(1, 2);
        fractions[1] = new Fraction(1, 3);
        fractions[2] = new Fraction(1, 6);
        fractions.Output();
    }

    private static void RunBai2_7()
    {
        Console.WriteLine("\n--- Bai 2.7 ---");
        Department department = new(2);
        RunWithInput(department.Input, "Nguyen An\n10000000\n1\nTran Binh\n12000000\n2\n");
        department.Output();
    }

    private static void RunBai3_1()
    {
        Console.WriteLine("\n--- Bai 3.1 ---");
        ArraySortExample.run();
    }

    private static void RunBai3_2()
    {
        Console.WriteLine("\n--- Bai 3.2 ---");
        int[] numbers = { 5, 1, 4, 2, 3 };
        ArraySortSimulate.Sort(numbers);
        Console.WriteLine(string.Join(" ", numbers));
    }

    private static void RunBai3_3()
    {
        Console.WriteLine("\n--- Bai 3.3 ---");
        string[] names = { "Chi", "An", "Binh" };
        DelegateFunc.Sort(names, string.Compare);
        Console.WriteLine(string.Join(" ", names));
    }

    private static void RunBai3_4()
    {
        Console.WriteLine("\n--- Bai 3.4 ---");
        PTBac2Console menu = new();
        RunWithInput(() => menu.run(0), "1\n1\n-3\n2\n2\n0\n");
    }

    private static void RunBai3_5()
    {
        Console.WriteLine("\n--- Bai 3.5 ---");
        NhanVien[] employees =
        {
            new NhanVienKinhDoanh("KD01", "Nguyen An", 8000000, 4),
            new NhanVienSanXuat("SX01", "Tran Binh", 3500)
        };
        foreach (NhanVien employee in employees)
        {
            Console.WriteLine($"{employee.MaNhanVien} - {employee.HoTen}: {employee.TinhLuong():N0}");
        }
    }

    private static void RunBai3_6()
    {
        Console.WriteLine("\n--- Bai 3.6 ---");
        ThiSinh[] candidates =
        {
            new ThiSinhChuyen("C01", "Le An", 7, 8, 9, 9),
            new ThiSinhSieuCup("S01", "Pham Chi", 8, 8, 8, 9)
        };
        foreach (ThiSinh candidate in candidates)
        {
            Console.WriteLine($"{candidate.SoBaoDanh} - {candidate.HoTen}: {candidate.TinhTongDiem()}");
        }
    }

    private static void RunWithInput(Action action, string input)
    {
        TextReader originalInput = Console.In;
        Console.SetIn(new StringReader(input));
        try
        {
            action();
        }
        finally
        {
            Console.SetIn(originalInput);
        }
    }
}