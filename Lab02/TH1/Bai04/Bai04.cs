public class Program4
{
    private static long Power(int x, int y)
    {
        if (y < 0) throw new ArgumentException("So mu khong duoc am");
        if(y==0) return 1;
        if(x==1) return 1;
        long half = Power(x, y / 2);
        if (y % 2 == 0){
            return half * half;
        }
        else{
            return half * half * x;
        }
    }
    public static void run()
    {
    Console.Write("Nhap so nguyen x: ");
    string input = Console.ReadLine() ?? string.Empty;
    if (!int.TryParse(input, out int x))
    {
        throw new ArgumentException($"'{input}' khong phai la so nguyen hop le");
    }
    Console.WriteLine($"Da nhap x = {x}");

    Console.Write("Nhap so nguyen y: ");
    string input2 = Console.ReadLine() ?? string.Empty;
    if (!int.TryParse(input2, out int y))
    {
        throw new ArgumentException($"'{input}' khong phai la so nguyen hop le");
    }
    Console.WriteLine($"Da nhap y = {y}");
    Console.WriteLine("Ket qua {0}^{1} la: {2}", x, y, Power(x,y));
    }
}