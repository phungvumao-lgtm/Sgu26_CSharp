public class Program1_1
{
    public static void run()
    {
        Console.WriteLine("Nhap ho va ten: ");
        string HoTen = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Da nhap ho va ten: " + HoTen);

        Console.WriteLine("Nhap nam sinh: ");
        int tuoi = 0;
        bool hopLe = int.TryParse(Console.ReadLine(), out int namSinh);

        if (hopLe)
        {
            Console.WriteLine($"Da nhap nam sinh: {namSinh}");
            tuoi = DateTime.Now.Year - namSinh;
        }
        else
        {
            Console.WriteLine("Chua nhap dung nam sinh!");
        }

        Console.WriteLine("Thong tin sinh vien - Ten: " + HoTen + " Tuoi: " + tuoi);
    }
}