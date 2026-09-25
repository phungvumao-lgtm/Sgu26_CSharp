public class Program2
{
     public static void run()
    {
        Console.WriteLine("Nhap ho va ten: ");
        string HoTen = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Da nhap ho va ten: " + HoTen);
        Console.WriteLine("Chao ban " + HoTen);
    }
}