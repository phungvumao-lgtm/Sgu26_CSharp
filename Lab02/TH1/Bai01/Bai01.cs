using System;

public class Program1
{
    public static void run1()
    {
        Console.WriteLine("Nhap ho va ten: ");
        string HoTen = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Da nhap ho va ten: " + HoTen);
        Console.WriteLine("Ho va ten ban vua nhap la: " + HoTen);
    }
}