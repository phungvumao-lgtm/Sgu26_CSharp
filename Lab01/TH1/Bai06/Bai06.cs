public class Program6
{
    static long maxNum(ref long a, ref long b, ref long c)
    {
        long maxAB = (a + b + Math.Abs(a - b)) / 2;
        long maxABC = (maxAB + c + Math.Abs(maxAB - c)) / 2;
        return maxABC;
    }

    public static void run()
    {
        long a = 7, b = 13, c = 5;
 
        long max = maxNum(ref a, ref b, ref c);
        Console.WriteLine($"Gia tri lon nhat trong 3 so: {max}");
    }
}