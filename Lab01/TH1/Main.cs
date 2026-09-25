public class MainTemplate
{
    public static void Main(String[] args)
    {
        RunAll();
    }

    public static void RunAll()
    {
        RunBai01();
        RunBai02();
        RunBai03();
        RunBai04();
        RunBai05();
        RunBai06();
        RunBai07();
        RunBai08();
        RunBai09();
        RunBai10();
        RunBai11();
        RunBai12();
        RunBai13();
        RunBai14();
        RunBai15();
        RunBai16();
        RunBai17();
    }

    private static void RunBai01()
    {
        Console.WriteLine("\n--- Bai 01 ---");
        RunWithInput(Program1.run1, "Nguyen Van An\n");
    }

    private static void RunBai02()
    {
        Console.WriteLine("\n--- Bai 02 ---");
        RunWithInput(Program2.run, "Nguyen Van Binh\n");
    }

    private static void RunBai03()
    {
        Console.WriteLine("\n--- Bai 03 ---");
        RunWithInput(Program3.run, "2\n10\n");
    }

    private static void RunBai04()
    {
        Console.WriteLine("\n--- Bai 04 ---");
        RunWithInput(Program4.run, "3\n4\n");
    }

    private static void RunBai05()
    {
        Console.WriteLine("\n--- Bai 05 ---");
        RunWithInput(Program5.run, "1\n9\n16\n2\n3\n4\n");
    }

    private static void RunBai06()
    {
        Console.WriteLine("\n--- Bai 06 ---");
        Program6.run();
    }

    private static void RunBai07()
    {
        Console.WriteLine("\n--- Bai 07 ---");
        RunWithInput(Program7.run, "29\n");
    }

    private static void RunBai08()
    {
        Console.WriteLine("\n--- Bai 08 ---");
        float first = 1.5f;
        float second = 2.5f;
        Program8.HoanVi(ref first, ref second);
        Console.WriteLine($"Sau hoan vi: {first}, {second}");
    }

    private static void RunBai09()
    {
        Console.WriteLine("\n--- Bai 09 ---");
        Program9.TimMaxMin(4.5f, -2f, 8f, out float maximum, out float minimum);
        Console.WriteLine($"Max = {maximum}, Min = {minimum}");
    }

    private static void RunBai10()
    {
        Console.WriteLine("\n--- Bai 10 ---");
        Console.WriteLine($"'radar' doi xung: {Program10.IsPalindrome("radar")}");
    }

    private static void RunBai11()
    {
        Console.WriteLine("\n--- Bai 11 ---");
        Console.WriteLine(Program11.DaoChuoi("CSharp"));
    }

    private static void RunBai12()
    {
        Console.WriteLine("\n--- Bai 12 ---");
        const string text = "Lap trinh CSharp";
        Console.WriteLine(Program12.ChuyenChuThuong(text));
        Console.WriteLine(Program12.ChuyenChuHoa(text));
        Console.WriteLine($"So tu: {Program12.DemSoTu(text)}");
    }

    private static void RunBai13()
    {
        Console.WriteLine("\n--- Bai 13 ---");
        SinhVien student = new() { MaSinhVien = "SV001", HoTen = "Le An", DiaChi = "TP.HCM", NamThu = 2 };
        student.Xuat();
    }

    private static void RunBai14()
    {
        Console.WriteLine("\n--- Bai 14 ---");
        NhanVien employee = new() { HoTen = "Tran Binh", MucLuong = 10000000m, SoNgayVang = 2 };
        employee.Xuat();
    }

    private static void RunBai15()
    {
        Console.WriteLine("\n--- Bai 15 ---");
        int[] numbers = { 2, 7, 4, 11, 8 };
        Program15.XuatMang(numbers);
        Console.WriteLine($"Max = {Program15.TimPhanTuLonNhat(numbers)}, Min = {Program15.TimPhanTuNhoNhat(numbers)}");
        Console.WriteLine("So nguyen to: " + string.Join(" ", Program15.LaySoNguyenTo(numbers)));
    }

    private static void RunBai16()
    {
        Console.WriteLine("\n--- Bai 16 ---");
        string[] names = { "Tran Binh", "Nguyen An", "Le Chi" };
        Program16.SapXepTangDan(names);
        Program16.XuatDanhSach(names);
    }

    private static void RunBai17()
    {
        Console.WriteLine("\n--- Bai 17 ---");
        int[,] matrix = Program17.SinhMang(2, 3);
        Program17.XuatMang(matrix);
        Program17.TachChanLe(matrix, out int[] evenNumbers, out int[] oddNumbers);
        Console.WriteLine("So chan: " + string.Join(" ", evenNumbers));
        Console.WriteLine("So le: " + string.Join(" ", oddNumbers));
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