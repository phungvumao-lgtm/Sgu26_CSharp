using System;

class Program5
{
    static double x, y;
    static bool daNhap = false;

    public static void run()
    {
        int choice;
        do
        {
            InMenu();
            choice = NhapSoNguyen("Chon chuc nang: ");

            switch (choice)
            {
                case 1:
                    NhapXY();
                    break;
                case 2:
                    TinhLuyThua();
                    break;
                case 3:
                    TinhCanBacHai();
                    break;
                case 4:
                    Console.WriteLine("Tam biet!");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
            Console.WriteLine();

        } while (choice != 4);
    }

    static void InMenu()
    {
        Console.WriteLine("MENU");
        Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
        Console.WriteLine("2. Tinh x^y");
        Console.WriteLine("3. Tinh can bac 2 cua x va y");
        Console.WriteLine("4. Thoat");
    }

    static void NhapXY()
    {
        x = NhapSoThuc("Nhap x: ");
        y = NhapSoThuc("Nhap y: ");
        daNhap = true;
        Console.WriteLine($"Da nhap: x = {x}, y = {y}");
    }

    static void TinhLuyThua()
    {
        if (!daNhap)
        {
            Console.WriteLine("Ban chua nhap x, y. Chon muc 1 truoc.");
            return;
        }
        double ketQua = Math.Pow(x, y);
        Console.WriteLine($"{x}^{y} = {ketQua}");
    }

    static void TinhCanBacHai()
    {
        if (!daNhap)
        {
            Console.WriteLine("Ban chua nhap x, y. Chon muc 1 truoc.");
            return;
        }

        if (x < 0)
            Console.WriteLine("Khong the tinh can bac 2 cua x vi x am.");
        else
            Console.WriteLine($"Can bac 2 cua x = {Math.Sqrt(x)}");

        if (y < 0)
            Console.WriteLine("Khong the tinh can bac 2 cua y vi y am.");
        else
            Console.WriteLine($"Can bac 2 cua y = {Math.Sqrt(y)}");
    }

    // ---- Ham nhap an toan, dung lai cho ca menu va so thuc ----

    static int NhapSoNguyen(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            if (int.TryParse(input, out int result))
            {
                Console.WriteLine($"Da nhap: {result}");
                return result;
            }
            Console.WriteLine($"'{input}' khong phai so nguyen hop le. Nhap lai.");
        }
    }

    static double NhapSoThuc(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? string.Empty;
            if (double.TryParse(input, out double result))
            {
                Console.WriteLine($"Da nhap: {result}");
                return result;
            }
            Console.WriteLine($"'{input}' khong phai so thuc hop le. Nhap lai.");
        }
    }
}